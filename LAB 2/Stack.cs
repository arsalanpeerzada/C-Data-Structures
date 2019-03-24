using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Stack
    {
        int top = -1;
       List<string> stack = new List<string>();

        public void Push(string Element)
        {
            stack.Add(Element);
            top++;
        }

        public string Pop()
        {
            string element = stack[top];
            stack.RemoveAt(top);
            top--;
            return element;
        }

        public int GetCount()
        {
            return stack.Count();
        }
    }
}
