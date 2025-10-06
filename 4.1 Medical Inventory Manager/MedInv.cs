using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System._4._1_Medical_Inventory_Manager
{
    public partial class MedInv : Form
    {
        private const int LowInventoryThreshold = 10; // Define low inventory threshold
        private string connectionString = "Data Source=localhost;Initial Catalog=HSM1;Integrated Security=True;TrustServerCertificate=True";
        public MedInv()
        {
            InitializeComponent();
            timer1.Interval = 30000; // 30 seconds
            timer1.Tick += Timer1_Tick;
        }

        private void MedInv_Load(object sender, EventArgs e)
        {
            // Set the ListView to use details view and add columns
            lstView_Inventory.View = View.Details;
            lstView_Inventory.Columns.Add("Name", 100, HorizontalAlignment.Left);
            lstView_Inventory.Columns.Add("Category", 100, HorizontalAlignment.Left);
            lstView_Inventory.Columns.Add("Description", 200, HorizontalAlignment.Left);
            lstView_Inventory.Columns.Add("Quantity", 70, HorizontalAlignment.Right);
            lstView_Inventory.Columns.Add("UnitPrice", 70, HorizontalAlignment.Right);

            // Start the timer
            timer1.Start();
            // Load data initially
            UpdateInventory();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            UpdateInventory();
        }

        private void UpdateInventory()
        {
            using (var context = new MedicationAndSuppliesDataContext())
            {
                // Query the inventory data
                var inventory = from item in context.MedicationsAndSupplies
                                select new
                                {
                                    item.Name,
                                    item.Category,
                                    item.Description,
                                    item.Quantity,
                                    item.UnitPrice
                                };

                // Bind the data to the ListView
                lstView_Inventory.Items.Clear();
                foreach (var item in inventory)
                {
                    ListViewItem listItem = new ListViewItem(item.Name);
                    listItem.SubItems.Add(item.Category);
                    listItem.SubItems.Add(item.Description);
                    listItem.SubItems.Add(item.Quantity.ToString());
                    listItem.SubItems.Add(item.UnitPrice.ToString("F2"));
                    lstView_Inventory.Items.Add(listItem);

                    // Check if inventory is low and show a notification
                    if (item.Quantity <= LowInventoryThreshold)
                    {
                        MessageBox.Show($"Inventory is low on item: {item.Name}", "Low Inventory Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            // Stop the timer when the form is closed
            timer1.Stop();
        }
    }
}