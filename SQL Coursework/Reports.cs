using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Configuration;
using System.Data.SqlClient;

namespace SQL_Coursework
{
    public partial class Reports : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SQL_Coursework.Properties.Settings.UserAuthConnectionString"].ConnectionString;

        string query = "SELECT Email FROM Staff";
        public Reports()
        {
            InitializeComponent();
        }
        private void SendReportByEmail(string reportPath, string recipient)
        {
            string email = Gather_Email();
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(email);
            mail.To.Add(recipient);
            mail.Subject = "Daily Maintenance Report";
            mail.Body = "Please find the attached maintenance report.";
            mail.Attachments.Add(new Attachment(reportPath));

            SmtpClient smtp = new SmtpClient("smtp.example.com");
            smtp.Credentials = new System.Net.NetworkCredential("movers.reports@gmail.com", "Movers123");
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }

        private void StockBtn_Click(object sender, EventArgs e)
        {

        }
        private string Gather_Email()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Get the email value from the Email column
                                string email = reader["Email"].ToString();

                                return email;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return "none found";
            }
        }
    }
}
