using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asementifile3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter outputfile;
            // creating new file create texe()
            outputfile = File.CreateText("c#test");

            //process file
            outputfile.WriteLine("welcome jamhuriya");
            outputfile.WriteLine("age:20");
            outputfile.WriteLine("java and c# programing ");
            // the close file
            outputfile.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using(StreamReader read=new StreamReader("c#test"))
            {
                while (read.Peek() != -1)
                {
                    listBox1.Items.Add(read.ReadLine());

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] xog = File.ReadAllBytes("c#test");
            MessageBox.Show("tirada byte-yada" + xog.Length);
            foreach(byte b in xog)
            {
                listBox1.Items.Add(b);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using(StreamReader read=new StreamReader("c#test"))
            {
                char[] b = new char[16];
                int tiro = read.ReadBlock(b, 0, b.Length);
                listBox1.Items.Add(new string(b, 0, tiro));

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string del = ("c#test");
            if (File.Exists(del))
            {
                File.Delete(del);
                MessageBox.Show("fil ka waldaleday");
            }
            else
            {
                MessageBox.Show("file ka lama dirin");
                

            }


        }
    }
}
