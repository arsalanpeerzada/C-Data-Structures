using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VLM_Assignment_Recorder1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();
        string input;
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                input= "Assigment # : "+textBox2.Text+" Student ID : "+textBox1.Text+" Marks Obtained :"+checkBox1.Text;
                list.Add(input);


            }
            else if (checkBox2.Checked)
            {
                input = "Assigment # : " + textBox2.Text + " Student ID : " + textBox1.Text + " Marks Obtained :" + checkBox2.Text;
                list.Add(input);
            }
            else if (checkBox3.Checked)
            {
                input = "Assigment # : " + textBox2.Text + " Student ID : " + textBox1.Text + " Marks Obtained :" + checkBox3.Text;
                list.Add(input);
            }
            else if (checkBox4.Checked)
            {
                input = "Assigment # : " + textBox2.Text + " Student ID : " + textBox1.Text + " Marks Obtained :" + checkBox4.Text;
                list.Add(input);

                
            }

            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled= true;
            checkBox4.Enabled= true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.AppendAllLines(@"c:\Users\Arsalan peerzada\Desktop\VLM.txt", list);
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = false;
            checkBox3.Enabled=false;
            checkBox4.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = false;
            checkBox1.Enabled = false;
            checkBox4.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
        }

    }
}
