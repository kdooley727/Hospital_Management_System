using Hospital_Management_System._2._2_Patient_Man;
using MongoDB.Driver;
using MongoDbRestaurantManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientChat;
using System.IO;
using System.Diagnostics;
using Hospital_Management_System._4._1_Medical_Inventory_Manager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Hospital_Management_System._3._3_Appointment_Scheduling;

namespace Hospital_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btn_Chat.Visible = false;
            groupBox4.Visible = false;

            buttonAnalytics.Visible = false;
            groupBox3.Visible = false;

            btn_MedInv.Visible = false;
            groupBox5.Visible = false;

            HMS_Bttn_PatientManage.Visible = false;
            groupBox2.Visible = false;
        }

        private void loginbttn_Click(object sender, EventArgs e)
        {
            // Login Button 
            Login login = new Login();
            login.ShowDialog();
            this.Hide();
        }

        public void SetUsernameLabel(string username, string role)
        {
            // Assuming you have a label named 'usernameLabel' on your form
            main_label_uname.Text = "Welcome, " + username + "!";
            main_label_utype.Text = "Role: " + role;

            // Hide or show buttons based on userRole
            switch (role)
            {
                case "Doctor":
                    //btn_MedInv.Visible = false;
                    //groupBox5.Visible = false;

                    buttonAnalytics.Visible = true;
                    groupBox3.Visible = true;
                    btn_Chat.Visible = true;
                    groupBox4.Visible = true;
                    HMS_Bttn_PatientManage.Visible = true;
                    groupBox2.Visible = true;
                    break;
                case "Patient":
                    //btn_MedInv.Visible = false;
                    //groupBox5.Visible = false;
                    //buttonAnalytics.Visible = false;
                    //groupBox3.Visible = false;
                    //HMS_Bttn_PatientManage.Visible = false;
                    //groupBox2.Visible = false;

                    btn_Chat.Visible= true;
                    groupBox4.Visible= true;
                    break;
                case "Nurse":
                    //btn_MedInv.Visible = false;
                    //groupBox5.Visible = false;

                    buttonAnalytics.Visible = true;
                    groupBox3.Visible = true;
                    btn_Chat.Visible = true;
                    groupBox4.Visible = true;
                    HMS_Bttn_PatientManage.Visible = true;
                    groupBox2.Visible = true;
                    break;
                case "Administrative Staff":
                    buttonAnalytics.Visible = true;
                    groupBox3.Visible = true;
                    btn_Chat.Visible = true;
                    groupBox4.Visible = true;
                    btn_MedInv.Visible = true;
                    groupBox5.Visible = true;
                    HMS_Bttn_PatientManage.Visible = true;
                    groupBox2.Visible = true;

                    break;
                default:
                    break;
            }

            
        }

        private void HMS_Bttn_PatientManage_Click(object sender, EventArgs e)
        {
            

            PatientManage patientManage = new PatientManage();
            patientManage.ShowDialog();


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // go to analytics forms
            Analytics analytics = new Analytics();
            analytics.ShowDialog();


            
        }

        private void btn_Chat_Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm();

            chatForm.Show();


            
        }

        private void btn_MedInv_Click(object sender, EventArgs e)
        {
            MedInv medInv = new MedInv();

            medInv.Show();


           
        }

        private void button1_Click_1(object sender, EventArgs e)
            // Appointment Scheduling Button
        {
            Appointments appointments = new Appointments();
            appointments.ShowDialog();
        }
    }
}

