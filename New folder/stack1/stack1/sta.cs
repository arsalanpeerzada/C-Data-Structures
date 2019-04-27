using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stack1
{
    class sta
    {
        int top = -1;
        List<string> Stack = new List<string>();
        public void Push(string element)
        {
            Stack.Add(element);
            top++;

        }
        public string Pop()
        {

            string element = Stack[top];
            Stack.RemoveAt(top);
            top--;
            return element;

        }
        public int GetCount()
        {
            return Stack.Count;

        }

    }
}
