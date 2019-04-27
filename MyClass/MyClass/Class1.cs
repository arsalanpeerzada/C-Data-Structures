using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClass
{
    class Class1
    {
        string name="Toyota";
        string model="Corolla";
        int year=2015;
        string speed="205 kph";

        public void setMethod(string _name,string _model,int _year,string _speed) //this is the method we use for set.if we dont use it then previous variables will be use.
        {
            name = _name;
            model = _model;
            year = _year;
            speed = _speed;
        }

        public void get()
        {
            Console.WriteLine(name);
            Console.WriteLine(model);
            Console.WriteLine(year);
            Console.WriteLine(speed);
        }


    }
}
