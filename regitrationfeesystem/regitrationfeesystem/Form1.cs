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

namespace regitrationfeesystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {//creating varible
                string name;
                int id, numbercourses, studylvele, transportfee;
                double feepercourses=0;//qimhaha corsada
                double discount = 0;
                double finalamoun=0;
                
                double tution=0;
             
                double discountrate = 0;
              
                //inzallion
                name = txtstudetname.Text;
                id = int.Parse(txtstudentid.Text);
                numbercourses = int.Parse(txtnumber.Text);
                studylvele = int.Parse(txtstudy.Text);
                transportfee = int.Parse(txttransportfee.Text);
                if (string.IsNullOrEmpty(name))
                {
                }

                    if (int.TryParse(txtnumber.Text, out numbercourses))

                    {

                    }
                    if (numbercourses < 1 || numbercourses > 8)
                    {
                        MessageBox.Show("numbercourses betwen 1 && 8");
                    }
                    if (int.TryParse(txtstudy.Text, out studylvele))
                    {
                        MessageBox.Show("select the level betwen 1&&4");
                    }
                    if (int.TryParse(txttransportfee.Text, out transportfee))
                    {

                    }
                    else if (transportfee != 40 && transportfee != 45 && transportfee != 50 && transportfee != 55)
                    {
                        MessageBox.Show("waxa most number eh 40,45,50,55");
                    }
                    switch (studylvele)
                    {
                        case 1:
                            feepercourses = 40;
                            break;
                        case 2:
                            feepercourses = 45;
                            break;
                        case 3:
                            feepercourses = 50;
                            break;
                        case 4:
                            feepercourses = 55;
                            break;
                    }
                
                








                            //lacgta assasiga
                            tution = numbercourses * feepercourses;


                            if (numbercourses >= 6)
                               discount = tution * 0.10;


                            //total
                            finalamoun = tution + transportfee - discount;


                    
                    lblname.Text = "name:" + name;
                    lbldiscount.Text = "discount:" + discount;
                    lblfinalamount.Text = "finalamon:" + finalamoun;
                    lblid.Text = "id:" + id;
                    lblnumbercourses.Text = "numbercorses:" + numbercourses;
                    lblstudyleyer.Text = "study level: year:" + studylvele;
                    lbltransport.Text = "transport:" + transportfee;
                    lbltution.Text = "tution:" + tution;






                


            }

            
            catch
            {

            }
            


            
            

                
              
      
            
           


               }

        private void butnclear_Click(object sender, EventArgs e)
        {
            txtnumber.Clear();
            txtstudentid.Clear();
            txtstudetname.Clear();
            txtstudy.Clear();
            txtstudy.Clear();
            txttransportfee.Clear();


            lblname.Text = " ";
            lbldiscount.Text = "";
            lblfinalamount.Text = " ";
            lblid.Text = "";
            lblnumbercourses.Text = "";
            lblstudyleyer.Text = "";
            lbltution.Text = "";
            lbltransport.Text = "";

        }

        private void butnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

