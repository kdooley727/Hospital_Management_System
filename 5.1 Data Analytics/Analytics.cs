using Hospital_Management_System._2._2_Patient_Man;
using Hospital_Management_System._4._1_Medical_Inventory_Manager;
using Hospital_Management_System._5._1_Data_Analytics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hospital_Management_System
{
    public partial class Analytics : Form
    {
        private DataAnalyticsDataContext db = new DataAnalyticsDataContext();
        
        public Analytics()
        {
            InitializeComponent();

            comboBox1.Items.Add("Patient Visits");
            comboBox1.Items.Add("Common Ailments");
            comboBox1.Items.Add("Medication Usage");
        }

        private void buttonAnalytics_Click(object sender, EventArgs e)
        {
            try
            {
                // Check what data user wants to see
                if (comboBox1.Text == "Patient Visits")
                {
                    // get patient visits data
                    var query = from a in db.AppointTableNews
                                join b in db.PatientTableNews on a.PatientID equals b.PatientID
                                select new
                                {
                                    a.AppID,
                                    a.PatientID,
                                    b.Patient_FName,
                                    b.Patient_LName,
                                    a.AppDay,
                                    a.AppTime
                                };
                    dataGridViewAnalytics.DataSource = query.ToList();
                }
                if (comboBox1.Text == "Common Ailments")
                {
                    var query = from a in db.Ailments
                                join b in db.PatientTableNews on a.PatientID equals b.PatientID
                                group new { a, b } by new { a.AilmentID, a.PatientID, b.Patient_FName, b.Patient_LName, a.AilmentDescription } into c
                                orderby c.Count() descending
                                select new
                                {
                                    c.Key.AilmentID,
                                    c.Key.PatientID,
                                    c.Key.Patient_FName,
                                    c.Key.Patient_LName,
                                    c.Key.AilmentDescription,
                                    Count = c.Count()
                                };

                    dataGridViewAnalytics.DataSource = query.ToList();


                }
                if (comboBox1.Text == "Medication Usage")
                {
                    // get medication usage in medications table
                    var query = from a in db.MedicationsUsages
                                join b in db.MedicationsAndSupplies on a.MedicationID equals b.ID
                                join c in db.PatientTableNews on a.PatientID equals c.PatientID
                                select new
                                {
                                    a.UsageID,
                                    a.PatientID,
                                    a.MedicationID,
                                    c.Patient_FName,
                                    c.Patient_LName,
                                    b.Name,
                                    b.Description
                                };

                    dataGridViewAnalytics.DataSource = query.ToList();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
