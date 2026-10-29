using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeassement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            //create a variables
            string dayofweak, nameofmooth,  fulldat , numericday, year;

            //intail value of variables
            dayofweak = txtdayoftheweak.Text;
            nameofmooth = txtmounth.Text;
            numericday = txtdayofthemonth.Text;
            year=txtyear.Text;
            int.Parse (txtdayofthemonth.Text);
            int.Parse (txtyear.Text);
            //strage process conction of full data
            fulldat = dayofweak + " " + nameofmooth + " " + numericday + " " + year;
            bloutput.Text = fulldat;

        }

        private void lblofthemooh_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // clearing textbox and lebal
            // clearng textbox
            txtdayoftheweak.Clear();
            txtmounth.Clear();
            txtdayofthemonth.Clear();
            txtyear.Clear();




            // clearing label not used clear function
            bloutput.Text = " ";
        }

        private void btnclouse_Click(object sender, EventArgs e)
        {
            //form close using this keyword and close function
            this.Close();
            
        }

        private void bloutput_Click(object sender, EventArgs e)
        {

        }
    }
}
