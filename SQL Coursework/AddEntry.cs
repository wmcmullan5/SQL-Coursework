using System;
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

        }
        private void MaintenanceLog()
        {

        }
        private void Staff()
        {

        }
        private void Job()
        {

        }
        private void Stock()
        {

        }
    }
}
