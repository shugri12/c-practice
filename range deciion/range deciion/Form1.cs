using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace range_deciion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncheack_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtnum.Text);
                if(number>=1&& number <= 10)
                {
                    lblresult.Text = "number is in the range";
                }
                else
                {
                    lblresult.Text = "number is outside the range";
                }
            }
            catch
            {
                MessageBox.Show("pleas so kali integer ");
            }
        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            lblresult.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
