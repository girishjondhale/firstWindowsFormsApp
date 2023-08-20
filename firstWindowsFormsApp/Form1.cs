using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (txtusename.Text == "Admin" && txtpassw.Text == "admin123")
            {
                MessageBox.Show("login success");
            }
            else
            {
                MessageBox.Show("login fail");
            }
        }

        private void buttoncancle_Click(object sender, EventArgs e)
        {
            txtusename.Clear();
            txtpassw.Clear();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
