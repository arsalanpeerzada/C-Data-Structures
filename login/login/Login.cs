using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    class Login
    {

        public void checks(string s)
        {
            string [] arr=new string [5];
            arr[0] = "Arsalan 2211";
            arr[1] = "Asad 7120";
            arr[2] = "Waqar 7277";
            arr[3] = "Hamas 7081";
            arr[4] = "Rohan 7244";


            for (int i = 0; i < arr.Length; i++)
            {
                if (s==arr[i])
                {
                    MessageBox.Show("WelCome");
                    Form2 obj = new Form2();
                    obj.Show();
                    break;
                }
            }
            MessageBox.Show("Wrong Password");
        }
    }
}
