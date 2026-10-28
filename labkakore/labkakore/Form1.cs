using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labkakore
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblq_Click(object sender, EventArgs e)
        {

        }

        private void labelt_Click(object sender, EventArgs e)
        {

        }

        private void labelu_Click(object sender, EventArgs e)
        {

        }

        private void btnclculate_Click(object sender, EventArgs e)
        {
            try
            {
              
                double discountrate=0;
                int numberpage=0;
                int subtotal = 0;
                double  dicountamount = 0;
                double totalamunt = 0;
                int discount = 0;
                if (int.TryParse(textnumberpakge.Text, out numberpage))
                {

                }
                int pricepakage;
                if(int.TryParse(textperpkage.Text,out pricepakage))
                {

                }
                if ( numberpage >=10)
                {
                    discountrate = 0.20;


                }
                if (numberpage>=20)
                {
                   discountrate = 0.30;

                }
                 if (numberpage >=50)
                {
                    discountrate =0.40;

                }
                 if (numberpage >=100)
                {
                    discountrate = 0.50;


                }
                if (numberpage < 0) {
                    MessageBox.Show("nagtive lama okalo");
                        }
                
                subtotal = numberpage * pricepakage;
               
                dicountamount = subtotal*discountrate;
                totalamunt = subtotal-dicountamount;


                





                softewesalesrepost.Items.Add("numberpkage" + " " + numberpage);
                softewesalesrepost.Items.Add("price package" + " " + pricepakage);
                softewesalesrepost.Items.Add("subtotal" + " " + subtotal);
                softewesalesrepost.Items.Add("discount rate" + " " + discountrate*100+"%");
                softewesalesrepost.Items.Add("discounamunt" + " " + dicountamount.ToString("c2"));
                softewesalesrepost.Items.Add("total" + " " + totalamunt);
                



                
             
                
                


            }
            catch (Exception)
            {
                MessageBox.Show("waqlad codkada");

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            softewesalesrepost.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
