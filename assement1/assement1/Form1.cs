using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assement1
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

        private void textstudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsemester_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)

        {
            string student_name, student_id, departement, semester,fulldata;
            student_name = txtname.Text;
            student_id = textstudentid.Text;
            departement = textdepartement.Text;
            semester = txtsemester.Text;
            fulldata = student_name + " " + student_id + " " + departement + " " + semester;
            ibouput.Text = fulldata;
        }

        private void bottonclear_Click(object sender, EventArgs e)
        {
            txtname.Clear() ;
            textstudentid.Clear();
            textdepartement.Clear();
            txtsemester.Clear();
            ibouput.Text = " ";

        }
    }
}
