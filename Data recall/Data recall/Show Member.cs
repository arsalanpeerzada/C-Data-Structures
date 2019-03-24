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
    public partial class Show_Member : Form
    {
        public Show_Member()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            string path1 = obj.path;

          string [] data= File.ReadAllLines(path1);

          foreach (var item in data)
          {
              richTextBox1.Text = item.ToString();
          }

        }

      
    }
}
