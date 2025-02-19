﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Reports next = new Reports();
            next.Show();
            this.Hide();
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

        private void button5_Click(object sender, EventArgs e)
        {
            MOT next = new MOT();
            next.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TableViewer next = new TableViewer();
            next.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vehicles next = new Vehicles();
            next.Show();
            this.Hide();
        }
    }
}
