using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Data_recall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string path = @"C:\Users\Arsalan peerzada\Desktop\Ozair Ahmed";

        private void button1_Click(object sender, EventArgs e)
        {
            string data=("Name:"+textBox1.Text+", Address:"+textBox2.Text+", Mobile#:"+textBox3.Text+", FavoriteDeal:"+textBox4.Text+"\n");


            File.AppendAllText(path, data);


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show_Member obj = new Show_Member();
            obj.Show();
            this.Hide();
        }


        
    }
}
