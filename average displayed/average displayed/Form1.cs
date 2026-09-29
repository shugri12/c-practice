using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace average_displayed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clculte_Click(object sender, EventArgs e)
        {
            try
            {
                double testscore1 = double.Parse(txtcenter.Text);
                double textscore2 = double.Parse(txtcenter.Text);
                double txtscore3 = double.Parse(txtend.Text);
                double avrage = (testscore1 + textscore2 + txtscore3) /3;
                
               
                lbloutput.Text =  avrage.ToString("f1");
                if (avrage >= 90)
                {
                    MessageBox.Show("grde A");



                }
                else if (avrage >= 80)
                {
                    MessageBox.Show("grade B");
                }
                else if (avrage >= 70)
                {
                    MessageBox.Show("grade C");

                }
                else if (avrage >= 60)
                {
                    MessageBox.Show("grade D");

                }
                else
                {
                    MessageBox.Show("grade f");
                }

                

            }
            catch
            {
                MessageBox.Show("PLEAS ENTER CORRECT NUMBER");
            }
        }

        private void clr_Click(object sender, EventArgs e)
        {
            txxstar.Clear();
            txtcenter.Clear();
            txtend.Clear();
            lbloutput.Text = " ";
        }

        private void ext_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
