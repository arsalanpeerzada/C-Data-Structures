using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Quiz
{
    public partial class Form2 : Form
    {
        int global;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int var)
        {
            global = var;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
