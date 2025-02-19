using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SQL_Coursework
{
    public partial class Login1 : Form
    {
        // Colors from specifications
        private readonly Color bgColor = ColorTranslator.FromHtml("#ecf1fe");
        private readonly Color accent1 = ColorTranslator.FromHtml("#dcbf85");
        private readonly Color accent2 = ColorTranslator.FromHtml("#93a29b");
        private readonly Color darkText = ColorTranslator.FromHtml("#60594d");
        private readonly Color darkest = ColorTranslator.FromHtml("#413620");

        public Login1()
        {
            InitializeComponent();
        }
        private void Login1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginUser.Text;
            string password = txtLoginPass.Text;

            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Login successful!");
                // Open next form here
                Menu next = new Menu();
                next.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.UserAuthConnectionString))
            {
                conn.Open();
                string hashedPassword = HashPassword(password);
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @User AND Password = @Pass";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@User", username);
                    cmd.Parameters.AddWithValue("@Pass", hashedPassword);
                    int result = (int)cmd.ExecuteScalar();
                    return result > 0;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateRegistration())
            {
                if (RegisterUser())
                {
                    MessageBox.Show("Registration successful!");
                    tabControl1.SelectedIndex = 0; // Switch to login tab
                }
            }
        }


        private bool ValidateRegistration()
        {
            // Check all fields
            if (string.IsNullOrWhiteSpace(txtRegUser.Text) ||
                string.IsNullOrWhiteSpace(txtRegPass.Text) ||
                string.IsNullOrWhiteSpace(txtRegJob.Text))
            {
                MessageBox.Show("Please fill all required fields");
                return false;
            }

            // Check password match
            if (txtRegPass.Text != txtRegConfirm.Text)
            {
                MessageBox.Show("Passwords do not match");
                return false;
            }

            // Check password complexity
            if (!Regex.IsMatch(txtRegPass.Text, @"^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*]).{8,}$"))
            {
                MessageBox.Show("Password must contain:\n- At least 8 characters\n- 1 uppercase letter\n- 1 number\n- 1 special character");
                return false;
            }

            return true;
        }

        private bool RegisterUser()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.UserAuthConnectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Users (Username, Password, JobTitle, AdminID) 
                                   VALUES (@User, @Pass, @Job, @Admin)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@User", txtRegUser.Text);
                        cmd.Parameters.AddWithValue("@Pass", HashPassword(txtRegPass.Text));
                        cmd.Parameters.AddWithValue("@Job", txtRegJob.Text);
                        cmd.Parameters.AddWithValue("@Admin", string.IsNullOrWhiteSpace(txtRegAdmin.Text) ?
                            (object)DBNull.Value : txtRegAdmin.Text);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Primary key violation
                {
                    MessageBox.Show("Username already exists");
                }
                else
                {
                    MessageBox.Show("Registration error: " + ex.Message);
                }
                return false;
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }

}
