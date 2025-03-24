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
using System.Configuration;

namespace SQL_Coursework
{
    public partial class AddEntry : Form
    {
        public AddEntry()
        {
            InitializeComponent();
            InitComboBox();
            Vehicles();
        }

        private void InitComboBox()
        {
            string[] CboxItems = new string[4]
            {
                "Vehicles",
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
                case 1: Staff(); break;
                case 2: Job(); break;
                case 3: Job(); break;
                case 4: Stock(); break;
                default: Vehicles(); break;

            }
        }
        private void Vehicles()
        {
            StaffEmailtxtbox.Hide();
            StaffFnametxtbox.Hide();
            StaffIDtxtbox.Hide();
            StaffSnametxtbox.Hide();
            Maint_logBtn.Hide();
            StaffBtn.Hide();
            jobEntryBtn.Hide();
            StockBtn.Hide();
            JobDateBox.Hide();
            JobDescriptiontxtbox.Hide();
            JobIdtxtbox.Hide();
            StockDesctxtbox.Hide();
            StockIDtxtbox.Hide();
            StockQuantitytxtbox.Hide();
            vehicleLiscensetxtbox.Show();
            VehicleIDtxtbox.Show();
            VehicleMottxtbox.Show();
            VehiclesBtn.Show();
            VehicleTypetxtbox.Show();
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
            StaffBtn.Show();
            StaffEmailtxtbox.Show();
            StaffFnametxtbox.Show();
            StaffIDtxtbox.Show();
            StaffSnametxtbox.Show();
            StockDesctxtbox.Hide();
            StockIDtxtbox.Hide();
            StockQuantitytxtbox.Hide();
            vehicleLiscensetxtbox.Hide();
            VehicleIDtxtbox.Hide();
            VehicleMottxtbox.Hide();
            VehicleTypetxtbox.Hide();
        }
        private void Job()
        {
            vehicleLiscensetxtbox.Hide();
            VehicleIDtxtbox.Hide();
            VehicleMottxtbox.Hide();
            VehicleTypetxtbox.Hide();
            StaffEmailtxtbox.Hide();
            StaffFnametxtbox.Hide();
            StaffIDtxtbox.Hide();
            StaffSnametxtbox.Hide();
            JobIdtxtbox.Show();
            JobDescriptiontxtbox.Show();
            JobDateBox.Show();
            Maint_logBtn.Hide();
            StaffBtn.Hide();
            VehiclesBtn.Hide();
            StockBtn.Hide();
            StockDesctxtbox.Hide();
            StockIDtxtbox.Hide();
            StockQuantitytxtbox.Hide();
            jobEntryBtn.Show();
        }
        private void Stock()
        {
            vehicleLiscensetxtbox.Hide();
            VehicleIDtxtbox.Hide();
            VehicleMottxtbox.Hide();
            VehicleTypetxtbox.Hide();
            StaffEmailtxtbox.Hide();
            StaffFnametxtbox.Hide();
            StaffIDtxtbox.Hide();
            StaffSnametxtbox.Hide();
            Maint_logBtn.Hide();
            StaffBtn.Hide();
            jobEntryBtn.Hide();
            VehiclesBtn.Hide();
            JobDateBox.Hide();
            JobDescriptiontxtbox.Hide();
            JobIdtxtbox.Hide();
            StockDesctxtbox.Show();
            StockIDtxtbox.Show();
            StockQuantitytxtbox.Show();
            StockBtn.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UploadEntryBtn_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MaintenanceConnectionString"].ConnectionString;

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
            string connectionString = ConfigurationManager.ConnectionStrings["MaintenanceConnectionString"].ConnectionString;


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Stock (stockID, stockDesc, quantity) VALUES (@stockID, @stockDesc, @quantity)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Adding parameters
                        cmd.Parameters.AddWithValue("@stockID", int.Parse(StockIDtxtbox.Text));
                        cmd.Parameters.AddWithValue("@stockDesc", StockDesctxtbox.Text);
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(StockQuantitytxtbox.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Stock data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void VehiclesBtn_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MaintenanceConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Vehicles (VehicleID, Type, MOT, LicensePlate) VALUES (@VehicleID, @Type, @MOT, @LicensePlate)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Adding parameters
                        cmd.Parameters.AddWithValue("@VehicleID", int.Parse(VehicleIDtxtbox.Text));
                        cmd.Parameters.AddWithValue("@Type", VehicleTypetxtbox.Text);
                        cmd.Parameters.AddWithValue("@MOT", VehicleMottxtbox.SelectionStart); // Storing the selected date
                        cmd.Parameters.AddWithValue("@LicensePlate", vehicleLiscensetxtbox.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vehicle data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void StaffBtn_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MaintenanceConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Staff (StaffID, FName, SName, Email) VALUES (@StaffID, @FName, @SName, @Email)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Adding parameters
                        cmd.Parameters.AddWithValue("@StaffID", int.Parse(StaffIDtxtbox.Text));
                        cmd.Parameters.AddWithValue("@FName", StaffFnametxtbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@SName", StaffSnametxtbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", StaffEmailtxtbox.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Maint_logBtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu next = new Menu();
            next.Show();
            this.Hide();
        }

        private void StockBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
