using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Coursework
{
    public partial class DailySchedule : Form
    {
        public DailySchedule()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }
        string connectionString = ConfigurationManager.ConnectionStrings["MaintenanceConnectionString"].ConnectionString;
        private void LoadEvents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id, EventTitle FROM Events WHERE EventDate = @date";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DeleteEventTxtBox.Text)) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Events WHERE EventDate = @date AND EventTitle = @title";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@title", DeleteEventTxtBox.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            DeleteEventTxtBox.Clear();
            LoadEvents();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddEventTxtBox.Text)) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Events (EventDate, EventTitle) VALUES (@date, @title)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@title", AddEventTxtBox.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            AddEventTxtBox.Clear();
            LoadEvents();
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu next = new Menu();
            next.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
