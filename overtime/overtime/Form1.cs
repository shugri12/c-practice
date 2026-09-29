using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {
           
            try
            {

              
                double hourrs = double.Parse(hoursworkedtexbox.Text);
                double raate = double.Parse(hourlypayratetextbox.Text);

                double grosspay;
                if (hourrs > 40)
                {
                    grosspay = hourrs * raate;
                        
                }
                else
                {
                    double regularyplay = 40 * raate;
                    double overtimehours = hourrs - 40;
                    double overtimepay = overtimehours + raate * 1.5;
                    grosspay = raate + overtimepay;
                }
                grosspaylabel.Text = grosspay.ToString("c");


            }
            catch
            {
                MessageBox.Show("PLEAS SO KALI NUMBER SAX  EH");
            }
               
            }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            hoursworkedtexbox.Clear();
            hourlypayratetextbox.Clear();
            grosspaylabel.Text = " ";
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

