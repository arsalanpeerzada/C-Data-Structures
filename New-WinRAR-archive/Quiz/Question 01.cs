using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Question_01 : Form
    {
        int a = 0;
        int fr = 0;
        public Question_01()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {
                a = 10;
                fr = fr + 1;
            }
            else if (radioButton1.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                a = -5;
            }
            else
            {
                a = 0;
            }
            Form f1 = new Question_02(a , fr);
            f1.Show();
            this.Hide();
        }
    }
}
