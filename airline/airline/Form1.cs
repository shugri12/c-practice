using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace airline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int passengerage = 0;
                    int tricket;
                double bagagest;
                bool approved=true;
                string travelglass=" ";
                double tikitprice=0;
                double basiccost;
                double discountrate = 0;
                double agediscount = 0;
                double totaldiscount = 0;
                double discount = 0;
                double insurce=0;
                double baggestfee = 0;
                

                //string passengername = txtpassengername.Text;
                //validation
                string name = txtpassengername.Text;
                if(string.IsNullOrEmpty(name))
                if (!int.TryParse(txtpassengerage.Text, out passengerage)) 

                 if (passengerage < 1 || passengerage > 100)
                {
                    MessageBox.Show("passenger age betwen 1 and 1000 years");
                }
                if (int.TryParse(txtnumberticket.Text, out tricket))
                  if (tricket < 1 || tricket > 5)
                    {
                        MessageBox.Show("tickets betwen 1 and 5");
                    }
                
                if(double.TryParse(txtbaggage.Text,out bagagest)||bagagest<0||bagagest>50)
                {
                    MessageBox.Show("baggest betwen 0 and 50kg");
                }
                if (radioButtonnormal.Checked) travelglass = "firstclasses";
                if (radioButtonbusiness.Checked) travelglass = "bussinesclasses";
                if (radioButtonnormal.Checked) travelglass = "normalclasses";


                switch (travelglass){
                    case "firstclasses":
                        tikitprice = 222;
                        break;
                    case "normalclasses":
                        tikitprice = 333;
                        break;
                    case " bussinessclasses":
                        tikitprice = 444;
                        break;
                        
                    
                }
                // bookin approvel(bool floog)
                //if(p)


                //cost conclution=qimatikidka an waxbo laku darin
                basiccost = tikitprice * tricket;
                if (tricket == 5)
                {
                    discountrate = 0.10;
                }
                else if(tricket >= 3)
                {
                    discountrate = 0.05;
                }
                  if (passengerage < 12)
                {
                    agediscount = 0.20;
                }
                else if (passengerage >= 60)
                {
                    agediscount = 0.10;
                }
                //insurce
                if (checkBoxadd.Checked){
                    insurce = 25 * tricket;
                    }
                if (bagagest > 20)
                    
                    {
                        baggestfee = (bagagest = 20) * 12;
                    }
                
                //total discount
                totaldiscount = basiccost - discount + insurce + baggestfee;


                 // Ka hultag in qoraalku isku buullamo
                listoutput.Items.Add(" Approved");
                listoutput.Items.Add("Name: " + passengerage);
                listoutput.Items.Add("Age: " + passengerage);
                listoutput.Items.Add("Number Of Tickets: " + tricket);
                listoutput.Items.Add("Basic Cost: $" + basiccost.ToString("F2"));
                listoutput.Items.Add("Discount: $" + discountrate.ToString("F2"));
                listoutput.Items.Add("Insurance: $" + insurce.ToString("F2"));
                listoutput.Items.Add("Bag's Fee: $" + baggestfee.ToString("F2"));
                listoutput.Items.Add("----------------------------------------");
                listoutput.Items.Add("Total: $" + totaldiscount.ToString("F2"));























            }
            catch
            {

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttoclear_Click(object sender, EventArgs e)
        {
            listoutput.Items.Clear();
            txtpassengername.Clear();
            txtbaggage.Clear();
            txtnumberticket.Clear();
            txtpassengerage.Clear();
            radioButtonfirst.Checked = false;
            radioButtonbusiness.Checked = false;
            radioButtonnormal.Checked = false;
            checkBoxadd.Checked = false;

        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
