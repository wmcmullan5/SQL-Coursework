using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SQL_Coursework
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = GetStoredUsername();
            string password = GetStoredPassword(username);
            if (IsAdmin(username, password))
            {
                MessageBox.Show("Access granted. Welcome Admin!");
                Reports next = new Reports();
                next.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access denied. You do not have admin privileges.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string GetStoredUsername()
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.UserAuthConnectionString))
            {
                string query = "SELECT TOP 1 Username FROM Users ORDER BY Username"; // Modify query as needed
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : string.Empty;
            }
        }

        private string GetStoredPassword(string username)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.UserAuthConnectionString))
            {
                string query = "SELECT Password FROM Users WHERE Username=@username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : string.Empty;
            }
        }
        private bool IsAdmin(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.UserAuthConnectionString))
            {
                string query = "SELECT AdminID FROM Users WHERE Username=@username AND Password=@password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null && result.ToString() == "admin123";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            AddEntry next = new AddEntry();
            next.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DailySchedule next = new DailySchedule();
            next.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TableViewer next = new TableViewer();
            next.Show();
            this.Hide();
        }
    }
}
