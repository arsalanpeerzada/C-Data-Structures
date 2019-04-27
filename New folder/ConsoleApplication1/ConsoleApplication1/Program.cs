using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //StackClass sta = new StackClass();

            //sta.Push("asif");
            //sta.Push("ahmed");
            //sta.Push("butt");
            //int stackCount = sta.GetCount();
            //for (int i = 0; i < stackCount; i++)
            //{
            //    Console.WriteLine(sta.Pop());
            //}
            

            //_list.Remove(4);
           // _list.RemoveRange(2,4);
            //List<int> _list1 = new List<int>();
            //_list.Add(1);
            //_list.Add(14);
            //_list.Add(93);
            //_list.Add(21);
            //_list.AddRange(_list1);
            //// _list.RemoveAt(3);
            //_list.RemoveRange(1, 7);
            //for (int i = 0; i < _list.Count; i++)
            //{
            //    Console.WriteLine(_list[i]);
            //}


            //1.Get A[6]
            //2.Repeat step 3,4,5,6 for  K = 2 to 6
            //3.PTR = K – 1, TEMP = A[K]
            //4.Repeat a, b while TEMP < A[PTR] and PTR>0
            //5.A[PTR+1] = A[PTR]
            //6.PTR = PTR – 1
            //a.A[PTR+1] = TEMP
            //b.K=K+1
            //7.Exit


            //int[] _array = new int[6];
            //for (int i = 0; i < _array.Length; i++)
            //{
            //    Console.Write("ENter Number: " );
            //    _array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int temp;
            //int ptr;
            //for (int k = 1; k < 6; k++)
            //{
            //    ptr = k - 1;
            //    temp = _array[k];

            //    while (ptr >= 0 && temp < _array[ptr])
            //    {
            //        _array[ptr + 1] = _array[ptr];
            //        ptr = ptr - 1;
                   
            //    }
            //    _array[ptr + 1] = temp;
            //}
            //for (int i = 0; i < _array.Length; i++)
            //{
            //    Console.WriteLine(_array[i]);
            //}

            //int a = 19;
            //int b = 6;
            //a =a + b;
            //b = a - b;
            //a = a - b;
            //Console.WriteLine(a );
            //Console.WriteLine(b);
            
            //insertion
            //Set X = Length(LA)
            //Read ITEM
            //Read POS
            //If POS > X  then Exit
            //Repeat steps 6 and 7 while X>=POS
            //Set LA[X+1] = LA[X]
            //Set X = X – 1
            //Set LA[POS] = ITEM

            //string[] _array = File.ReadAllLines("C:\\Users\\7087\\Desktop\\pakistan.txt");
            //string[] a = new string[_array.Length];
            //for (int i = 0; i < _array.Length; i++)
            //{
            //     a = _array[i].Split(new string[]{ ",",".",}, StringSplitOptions.RemoveEmptyEntries);
            //}
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}

            //char[] sub_Array = new char[8];
            //char[] str1 = new char[8] { 'p', 'a', 'k', 'i', 's', 't', 'a', 'n' };
            //int str_pos = 3;
            //int nOC = 3;
            //int _length = (str_pos + nOC) - 1;
            //int j = 0;
            //for (int i = str_pos-1; i < _length; i++)
            //{
            //    sub_Array[j] = str1[i];
            //    j++;
            //}
            //for (int i = 0; i < _length; i++)
            //{
            //    Console.WriteLine(sub_Array[i]);
            //}

            string[] fileData = File.ReadAllLines(@"C:\Users\7087\Desktop\pakistan.txt");
            Regex reg = new Regex(@"[0-9][0-9][/]+[0-9][0-9][/]+[0-9][0-9][0-9][0-9]");
            

            foreach (var item in fileData)
            {
                string[] temp = item.Split(new[] { ',', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < temp.Length; i++)
                {
                    if (reg.IsMatch(temp[i]))
                    {
                        Console.WriteLine(temp[i]);
                    }
                    
                }
            }


        }
    }
}
