using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace hotelroombooking
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
                int age;
                int numbernigh;
                int numberguests;
                string roomtype = " ";
                int rate = 0;
                bool approved = true;
                decimal discount = 0;
                int maxgust = 0;
                int cost = 0;
                decimal nightdiscount=0;
                decimal afterdiscount=0;
                decimal breakfast = 0;
                decimal surcharg = 0;
                decimal seniordescount = 0;
                decimal total=0;
                //inizalition
                string name = txtguesname.Text;
                age = int.Parse(txtguestage.Text);
                 numbernigh =int.Parse(txtnumbernight.Text);
                numberguests=int.Parse(txtguestnumber.Text);


               
                // hubinta magaca ino bananyhay ino speac yahy
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("pleas so gali magac");
                    return;

                }
                // step2:valid all numeric input using tryparse
                // dada martida
                
             
                if (int.TryParse(txtguestage.Text, out age))
                {
                    // steps3 valide the allowed rangs
                    if (age < 18 || age >= 90)
                    {
                        MessageBox.Show("please  enter age betwen 18 and 90");
                    }

                    }
                    //tirada habenka
                  
                    if (int.TryParse(txtnumbernight.Text, out numbernigh))
                    {
                        // steps3 valide the allowed rangs
                        if (numbernigh < 1 || numbernigh > 30)
                        {
                            MessageBox.Show("pleas enter numbernight betwen 1 and 30");
                        }
                    }
                    // tirada martida
                   
                    if (int.TryParse(txtguestnumber.Text, out numberguests))
                    {
                        // steps3 valide the allowed rangs
                        if (numberguests < 1 || numberguests > 6)
                        {
                            MessageBox.Show("pleaase enter numberguests betwen 1 and 6"); ;
                        }
                       
                        // //swith stetment
                        if (radiostandard.Checked) roomtype = "standard";
                        else if (radionormal.Checked) roomtype = "normal";
                        else if (radiohight.Checked) roomtype = "hight";

                        switch (roomtype)
                        {


                            case "standard":
                            //qimaha qoka
                                rate = 50;
                            
                                maxgust = 2;
                                break;
                            case "normal":
                                rate = 80;
                                maxgust = 4;
                                break;
                            case "hight":
                                rate = 130;
                           
                                maxgust = 6;
                                break;
                            default:
                                {
                                    MessageBox.Show("pleas select room type");

                                }
                                break;


                        }
                        // inusan   1 mel ebar eheeyn room type
                        if(roomtype!=" "&& numberguests > maxgust)
                        {
                            MessageBox.Show(roomtype + "room allow a miximun of" + maxgust + "gustes sorry");
                        }
                        // hadi qof gastamaerka la aqbalayo
                        if (approved == true)
                        {
                          

                        }
                        else
                        {
                            MessageBox.Show(" geust its not aprovid");
                        }
                        //inta haben jiiftay qimahiisa
                        cost = rate * numbernigh;
                        if(numbernigh>=5)
                        {
                            discount = 0.05m;
                            
                        }
                        else if (numbernigh >= 10)
                        {
                            discount = 0.12m;
                        }
                        // waa variable laku kedinayo marko qof 5 malin kbadan hadu sexdo discount helaayo
                        nightdiscount = cost * discount;
                        afterdiscount = cost - nightdiscount;
                        if (chck.Checked)
                        {
                            //in laku daro qof hade cheackbox uso saro ina laku daro 10 dollar
                            breakfast =10 * numbernigh;
                           
                           
                            
                        }
                        if (age >= 60)
                        {
                            seniordescount = afterdiscount * 0.05m;


                        }
                        if (numberguests >= 4)
                        {
                            surcharg = afterdiscount * 0.05m;
                        }

                        total = afterdiscount - seniordescount -surcharg + breakfast;
                        


                    }
                    bookindetials.Items.Add(approved);
                    bookindetials.Items.Add("          ");
                    bookindetials.Items.Add("name"+" "+name );
                    bookindetials.Items.Add("age"+ " "+age );
                    bookindetials.Items.Add("guest number"+  " "+    numberguests );
                    bookindetials.Items.Add("number nights" + " "+numbernigh);
                    bookindetials.Items.Add("                          ");
                    bookindetials.Items.Add("cost$" + " "+ cost);
                    bookindetials.Items.Add("rate$" +  "  "+  rate);
                    bookindetials.Items.Add("roomtype"+ " "+roomtype  );
                    bookindetials.Items.Add("seniorderdiscount"+ " "+seniordescount );
                    bookindetials.Items.Add("discount"+ " "+discount  );
                    bookindetials.Items.Add("                          ");
                    bookindetials.Items.Add("surcharg$"+ " "+surcharg );
                    bookindetials.Items.Add("breakfast$"+" "+   breakfast );
                    bookindetials.Items.Add("after discount"+ " "+ afterdiscount );
                    bookindetials.Items.Add("nightdiscoun$"+ " "+nightdiscount );
                    bookindetials.Items.Add("                          ");

                    bookindetials.Items.Add("total cost$"+" "+total);
                bookindetials.Items.Add("                 ");
                
                



            }




















            catch { }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            bookindetials.Items.Clear();
            txtguesname.Clear();
            txtnumbernight.Clear();
            txtguestage.Clear();
            txtguestnumber.Clear();
            radiostandard.Checked = false;
            radionormal.Checked = false;
            radiohight.Checked = false;
            chck.Checked = false;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
