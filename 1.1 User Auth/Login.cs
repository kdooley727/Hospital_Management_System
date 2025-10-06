using MongoDB.Driver;
using MongoDbRestaurantManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Hospital_Management_System
{
    public partial class Login : Form
    {
        IMongoCollection<User> users;
        public Login()
        {
            InitializeComponent();

            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);

            users = database.GetCollection<User>("Users"); // Users collection from the hospital db
        }

        private void loginbttn_Click(object sender, EventArgs e)
        {
            // get infro from the user
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string role = GetSelectedRole();
      

            // check user info in the database to see if it exists
            var filter = Builders<User>.Filter.Eq("Username", username) &
                Builders<User>.Filter.Eq("Password", password) &
                Builders<User>.Filter.Eq("Role", role);

            var user = users.Find(filter).FirstOrDefault();

            // If user exist, send them to the main form, otherwise show them the error message
            if (user != null)
            {

                MessageBox.Show("You Logged In");

                OpenMainForm(user.Username, user.Role);

            }
            else
            {
                // error, Login failed
                MessageBox.Show("Invalid username or password");
            }
        }

        private void OpenMainForm(string username, string role)
        {
            Form1 mainForm = new Form1();
            mainForm.SetUsernameLabel(username, role);
            mainForm.Show();
            this.Hide();
        }

        private string GetSelectedRole()
        {
            if (radioButtonDoctor.Checked)
            {
                return radioButtonDoctor.Text;
            }
            else if (radioButtonNurse.Checked)
            {
                return radioButtonNurse.Text;
            }
            else if (radioButtonAdministrativeStaff.Checked)
            {
                return radioButtonAdministrativeStaff.Text;
            }
            else if (radioButtonPatient.Checked)
            {
                return radioButtonPatient.Text;
            }
            else
            {
                return string.Empty;
            }
        }

        private void registerbttn_Click(object sender, EventArgs e)
        {
            // Info from the user
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string role = GetSelectedRole();

            // check if user exist
            var filer = Builders<User>.Filter.Eq("Username", username);
            var userExists = users.Find(filer).FirstOrDefault();

            if (userExists == null)
            {
                // add the user to thje Mongodb
                //create an instance of the object user

                var user = new User
                {
                    Username = username,
                    Password = password,
                    Role = role
                };

                //4. Add it to the database
                users.InsertOne(user);

                MessageBox.Show("Registration Successful");

            }
            else
            {
                // user already exist, show them the message
                MessageBox.Show("Username already exist, Please choose a different one");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
