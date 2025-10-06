using Hospital_Management_System._2._2_Patient_Man;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System._3._3_Appointment_Scheduling
{
    public partial class Appointments : Form
    {
        private patientDataClasses1DataContext db = new patientDataClasses1DataContext();

        public Appointments()
        {
            InitializeComponent();
            this.btnAddAppointment.Click += new System.EventHandler(this.button1_Click); // Add Appointment
            this.btnDeleteAppointment.Click += new System.EventHandler(this.button2_Click); // Cancel Appointment
            this.Load += new System.EventHandler(this.Appointments_Load); // Load appointments when form loads
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            try
            {
                var appointments = from a in db.AppointTableNews
                                   select new
                                   {
                                       a.AppID,
                                       a.PatientID,
                                       a.AppDay,
                                       a.AppTime
                                   };

                dataGridViewAppointments.DataSource = appointments.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading appointments: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add Appointment
            try
            {
                int patientID;
                if (int.TryParse(txtPatientID.Text, out patientID))
                {
                    DateTime appointmentDateTime = dtpAppointmentDateTime.Value;
                    AppointTableNew newAppointment = new AppointTableNew
                    {
                        PatientID = patientID,
                        AppDay = appointmentDateTime.Date,
                        AppTime = appointmentDateTime.TimeOfDay
                    };

                    db.AppointTableNews.InsertOnSubmit(newAppointment);
                    db.SubmitChanges();

                    MessageBox.Show("Appointment Added Successfully!");
                    LoadAppointments();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Patient ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cancel Appointment
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridViewAppointments.SelectedRows[0];
                    int appID = Convert.ToInt32(selectedRow.Cells["AppID"].Value);
                    var appointmentToDelete = db.AppointTableNews.SingleOrDefault(a => a.AppID == appID);
                    if (appointmentToDelete != null)
                    {
                        db.AppointTableNews.DeleteOnSubmit(appointmentToDelete);
                        db.SubmitChanges();

                        MessageBox.Show("Appointment Canceled Successfully!");
                        LoadAppointments();
                    }
                    else
                    {
                        MessageBox.Show("Appointment not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to cancel.");
            }
        }

        private void dataGridViewAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewAppointments.Rows[e.RowIndex];
                txtAppID.Text = selectedRow.Cells["AppID"].Value.ToString();
                txtPatientID.Text = selectedRow.Cells["PatientID"].Value.ToString();
                dtpAppointmentDateTime.Value = Convert.ToDateTime(selectedRow.Cells["AppDay"].Value).Add((TimeSpan)selectedRow.Cells["AppTime"].Value);
            }
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            // Update Appointment code here
        }
    }
}
