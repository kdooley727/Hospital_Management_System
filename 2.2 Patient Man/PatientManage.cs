using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System._2._2_Patient_Man
{
    public partial class PatientManage : Form
    {
        private patientDataClasses1DataContext db = new patientDataClasses1DataContext();
        public PatientManage()
        {
            InitializeComponent();

            this.patientman_add_bttn.Click += new System.EventHandler(this.patientman_add_bttn_Click);
            this.patientman_update_bttn.Click += new System.EventHandler(this.patientman_update_bttn_Click);
            this.patientman_del_bttn.Click += new System.EventHandler(this.patientman_del_bttn_Click);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PatientManage_Load(object sender, EventArgs e)
        {
            var query = from p in db.PatientTableNews
                        select new
                        {
                            p.PatientID,
                            p.Patient_FName,
                            p.Patient_LName,
                            p.Patient_Phone,
                            p.Patient_Address,
                            p.Patient_Insurance
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void patientman_add_bttn_Click(object sender, EventArgs e)
        {
            // Extract patient details from text boxes
            int PatientID;
            if (int.TryParse(patientman_txtbox_patientid.Text, out PatientID))
            {
                // Successful conversion
            }
            else
            {
                // Handle the case where the conversion fails

                PatientID = -1; // default error 
                MessageBox.Show("Please enter a valid patient ID.");
            }
            string firstName = Patientman_txtbox_fname.Text;
            string lastName = Patientman_txtbox_Lname.Text;
            string phone = Patientman_txtbox_phone.Text;
            string address = Patientman_txtbox_address.Text;
            string insurance = Patientman_txtbox_insurance.Text;

            // Create a new patient record
            PatientTableNew newPatient = new PatientTableNew
            {
                PatientID = PatientID,
                Patient_FName = firstName,
                Patient_LName = lastName,
                Patient_Phone = phone,
                Patient_Address = address,
                Patient_Insurance = insurance
                // Add more properties as needed
            };

            // Add the new patient to the database
            db.PatientTableNews.InsertOnSubmit(newPatient);
            db.SubmitChanges();

            // Refresh the DataGridView
            PatientManage_Load(sender, e);
        }

        private void patientman_update_bttn_Click(object sender, EventArgs e)
        {
            // Extract patient details from text boxes
            int PatientID;
            if (int.TryParse(patientman_txtbox_patientid.Text, out PatientID))
            {
                // Successful conversion
            }
            else
            {
                // Handle the case where the conversion fails

                PatientID = -1;
                MessageBox.Show("Please enter a valid patient ID.");
            }
            string firstName = Patientman_txtbox_fname.Text;
            string lastName = Patientman_txtbox_Lname.Text;
            string phone = Patientman_txtbox_phone.Text;
            string address = Patientman_txtbox_address.Text;
            string insurance = Patientman_txtbox_insurance.Text;

            // Find the patient record to update
            var patientToUpdate = db.PatientTableNews.SingleOrDefault(p => p.PatientID == PatientID);

            if (patientToUpdate != null)
            {
                // Update the patient record
                patientToUpdate.Patient_FName = firstName;
                patientToUpdate.Patient_LName = lastName;
                patientToUpdate.Patient_Phone = phone;
                patientToUpdate.Patient_Address = address;
                patientToUpdate.Patient_Insurance = insurance;
                // Update more properties as needed

                db.SubmitChanges();

                // Refresh the DataGridView
                PatientManage_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Patient not found.");
            }
        }

        private void patientman_del_bttn_Click(object sender, EventArgs e)
        {
            // Get the PatientID from the text box or selected row
            int PatientID;
            if (int.TryParse(patientman_txtbox_patientid.Text, out PatientID))
            {
                // Successful conversion
            }
            else
            {
                // Handle the case where the conversion fails

                PatientID = -1;
                MessageBox.Show("Please enter a valid patient ID.");
            };

            // Find the patient record to delete
            var patientToDelete = db.PatientTableNews.SingleOrDefault(p => p.PatientID == PatientID);

            if (patientToDelete != null)
            {
                // Delete the patient record
                db.PatientTableNews.DeleteOnSubmit(patientToDelete);
                db.SubmitChanges();

                // Refresh the DataGridView
                PatientManage_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Patient not found.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if the click is on a valid cell (not on header or out of bounds)
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    // Get the PatientID from the selected row
                    int patientID;
                    if (int.TryParse(selectedRow.Cells["PatientID"].Value.ToString(), out patientID))
                    {
                        // Query the ailments for the selected patient
                        var ailmentsQuery = from a in db.Ailments
                                            where a.PatientID == patientID
                                            select new
                                            {
                                                a.AilmentID,
                                                a.PatientID,
                                                a.AilmentDescription,
                                                a.AilmentDate
                                            };

                        // Display the ailments in another DataGridView or other UI element
                        // dump all to  dataGridView2
                        dataGridView2.DataSource = ailmentsQuery.ToList();
                    }
                }
            }
        }
    }
}
