﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Coursework
{
    public partial class TableViewer : Form
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;";

        public TableViewer()
        {
            InitializeComponent();
            dataGridView.ReadOnly = true;
        }

        private void LoadAllData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Vehicles";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;
                    Title.Text = $"Loaded {dt.Rows.Count} rows";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuery.Text))
            {
                Title.Text = "Please enter a query";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(txtQuery.Text.Trim(), conn);

                    // Try to execute as SELECT query
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView.DataSource = dt;
                        Title.Text = $"Loaded {dt.Rows.Count} rows";
                        return;
                    }
                    catch (SqlException) { }

                    // If not SELECT, execute as non-query
                    conn.Open();
                    int affected = cmd.ExecuteNonQuery();
                    Title.Text = $"Operation completed. Rows affected: {affected}";
                    LoadAllData(); // Refresh data
                }
            }
            catch (SqlException ex)
            {
                Title.Text = $"Error: {ex.Message}";
            }
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu next = new Menu();
            next.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEntry next = new AddEntry();
            next.Show();
            this.Hide();
        }

        private void TableViewer_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddEntry next = new AddEntry();
            next.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuery.Text))
            {
                Title.Text = "Please enter a query";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(txtQuery.Text.Trim(), conn);

                    // Try to execute as SELECT query
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView.DataSource = dt;
                        Title.Text = $"Loaded {dt.Rows.Count} rows";
                        return;
                    }
                    catch (SqlException) { }

                    // If not SELECT, execute as non-query
                    conn.Open();
                    int affected = cmd.ExecuteNonQuery();
                    Title.Text = $"Operation completed. Rows affected: {affected}";
                    LoadAllData(); // Refresh data
                }
            }
            catch (SqlException ex)
            {
                Title.Text = $"Error: {ex.Message}";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Stock";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;
                    Title.Text = $"Loaded {dt.Rows.Count} rows";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuery.Text))
            {
                Title.Text = "Please enter a query";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(txtQuery.Text.Trim(), conn);

                    // Try to execute as SELECT query
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView.DataSource = dt;
                        Title.Text = $"Loaded {dt.Rows.Count} rows";
                        return;
                    }
                    catch (SqlException) { }

                    // If not SELECT, execute as non-query
                    conn.Open();
                    int affected = cmd.ExecuteNonQuery();
                    Title.Text = $"Operation completed. Rows affected: {affected}";
                    LoadAllData(); // Refresh data
                }
            }
            catch (SqlException ex)
            {
                Title.Text = $"Error: {ex.Message}";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuery.Text))
            {
                Title.Text = "Please enter a query";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(txtQuery.Text.Trim(), conn);

                    // Try to execute as SELECT query
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView.DataSource = dt;
                        Title.Text = $"Loaded {dt.Rows.Count} rows";
                        return;
                    }
                    catch (SqlException) { }

                    // If not SELECT, execute as non-query
                    conn.Open();
                    int affected = cmd.ExecuteNonQuery();
                    Title.Text = $"Operation completed. Rows affected: {affected}";
                    LoadAllData(); // Refresh data
                }
            }
            catch (SqlException ex)
            {
                Title.Text = $"Error: {ex.Message}";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu next = new Menu();
            next.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Menu next = new Menu();
            next.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Menu next = new Menu();
            next.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddEntry next = new AddEntry();
            next.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddEntry next = new AddEntry();
            next.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Staff";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;
                    Title.Text = $"Loaded {dt.Rows.Count} rows";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
        }
    }
}
