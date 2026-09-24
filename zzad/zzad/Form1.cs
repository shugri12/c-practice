using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zzad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string guestname = txtguestname.Text;
                string roomtype = txtroomtype.Text;
                int night = int.Parse(txtnights.Text);
                double pricepernight = double.Parse(txtpricenight.Text);
                double subtotal = pricepernight * night;
                double servicetex = subtotal * 0.10;
                double dicount = subtotal * 0.05;
                double total= subtotal + servicetex - dicount;
              lblservicetex.Text = servicetex.ToString("c2");
                lbldiscount.Text = dicount.ToString("c2");
                lbltotalamount.Text = total.ToString("c2");
            }
            catch
            {
                MessageBox.Show("pleas enter the correct information.");
            }
        }

        private void lblservicetax_Click(object sender, EventArgs e)
        {

        }

        private void lbltotalamount_Click(object sender, EventArgs e)
        {

        }
    }
}
