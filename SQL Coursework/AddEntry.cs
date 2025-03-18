using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQL_Coursework
{
    public partial class AddEntry : Form
    {
        public AddEntry()
        {
            InitializeComponent();
            InitComboBox();
        }

        private void InitComboBox()
        {
            string[] CboxItems = new string[5]
            {
                "Vehicles",
                "Maintenance Log",
                "Staff",
                "Job",
                "Stock"
            };
            for (int i = 0; i < CboxItems.Length; i++)
            {
                comboBox1.Items.Add(CboxItems[i]);
            }
        }


        private void AddEntry_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBox();
        }

        private void CheckComboBox()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: Vehicles(); break;
                case 1: MaintenanceLog(); break;
                case 2: Staff(); break;
                case 3: Job(); break;
                case 4: Job(); break;
                case 5: Stock(); break;
                default: Vehicles(); break;

            }
        }
        private void Vehicles()
        {
            Maint_logBtn.Hide();
            StaffBtn.Hide();
            jobEntryBtn.Hide();
            StockBtn.Hide();
            JobDateBox.Hide();
            JobDescriptiontxtbox.Hide();
            JobIdtxtbox.Hide();
        }
        private void MaintenanceLog()
        {
            VehiclesBtn.Hide();
            StaffBtn.Hide();
            jobEntryBtn.Hide();
            StockBtn.Hide();
            JobDateBox.Hide();
            JobDescriptiontxtbox.Hide();
            JobIdtxtbox.Hide();
        }
        private void Staff()
        {
            Maint_logBtn.Hide();
            VehiclesBtn.Hide();
            jobEntryBtn.Hide();
            StockBtn.Hide();
            JobDateBox.Hide();
            JobDescriptiontxtbox.Hide();
            JobIdtxtbox.Hide();
        }
        private void Job()
        {
            JobIdtxtbox.Show();
            JobDescriptiontxtbox.Show();
            JobDateBox.Show();
            Maint_logBtn.Hide();
            StaffBtn.Hide();
            VehiclesBtn.Hide();
            StockBtn.Hide();
        }
        private void Stock()
        {
            Maint_logBtn.Hide();
            StaffBtn.Hide();
            jobEntryBtn.Hide();
            VehiclesBtn.Hide();
            JobDateBox.Hide();
            JobDescriptiontxtbox.Hide();
            JobIdtxtbox.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UploadEntryBtn_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Job (jobID, jobDate, jobDescription) VALUES (@jobID, @jobDate, @jobDescription)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Adding parameters
                        cmd.Parameters.AddWithValue("@jobID", int.Parse(JobIdtxtbox.Text));
                        cmd.Parameters.AddWithValue("@jobDate", JobDateBox.SelectionStart);
                        cmd.Parameters.AddWithValue("@jobDescription", JobDescriptiontxtbox.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Insertion failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StockBtn_Click(object sender, EventArgs e)
        {

        }

        private void VehiclesBtn_Click(object sender, EventArgs e)
        {

        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {

        }

        private void Maint_logBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
