﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Question_02 : Form
    {
        int c = 0;
        int fr = 0;
        public Question_02(int d, int a)
        {
            InitializeComponent();
            c = d;
            fr = a;
        }
        public Question_02()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (radioButton3.Checked)
            {
                c = c + 10;
                fr = fr + 1;
            }
            else if (radioButton1.Checked || radioButton2.Checked || radioButton4.Checked)
            {
                c = c - 5;
            }
            else
            {
                c = c+0;
            }
            Form f1 = new Question_03(c, fr);
            f1.Show();
            this.Hide();
           

        }
    }
}
