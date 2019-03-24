using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ds_assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string q="A+(B*C-(D/E~F)*G)*H";
            List<string> p = new List<string>();
           // Stack<string> list = new Stack<string>();
           MyStack Stack = new MyStack();
            Stack.Push("(");
            q += ")";
            string expression1 = @"[A-z]";
            string expression2= @"^([-+/*]\d+(\.\d+)?)*";
            string element="";
          //  int priority = 0;

            foreach (var item in q)
            {
               
                if (Regex.IsMatch(item.ToString(),expression1)) 
                {
                    p.Add(item.ToString());
                   // Console.WriteLine(item.ToString());
                }
                else if (item=='(')
                {
                    Stack.Push(item.ToString());
                   
                }
                else if (item == ')')
                {
                    while (Stack.peek()!="(")
                    {
                        p.Add(Stack.Pop());
                       // Console.WriteLine(Stack.Peek);
                        
                    }
                    Stack.Pop();
                    
                }
                else if (Regex.IsMatch(item.ToString(),expression2))
                {
                    if (item=='-')
                    {
                       // Console.WriteLine(Stack.Peek());
                        p.Add(Stack.Pop());

                    }
                    Stack.Push(item.ToString());
                }
                
            }


            for (int i = 0; i < p.Count; i++)
            {
                Console.Write(p[i]);
            }
        }
    }
}
