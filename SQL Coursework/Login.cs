using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SQL_Coursework
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //switched to highlighted button
        private void SwitchBtn(object sender, EventArgs e)
        {
            registerbtn.Image = Properties.Resources.Heading__1_;
        }
        //switches back to regular button
        private void SwitchBtnBack(object sender, EventArgs e)
        {
            registerbtn.Image = Properties.Resources.Heading;
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
