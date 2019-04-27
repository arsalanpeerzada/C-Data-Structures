using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class StackClass
    {

        //string popped = "";
        //string pushed = "";
        
        //public void Push(string item, List<string> a)
        //{
        //    this.pushed = item;
        //    a.Add(item);
        
        //}

        //public void Pop(List<string> a)
        //{
        //    this.popped = a.Last();
        //    a.Remove(this.popped);
        
        //}

        int top = -1;
        List<string> Stack = new List<string>();
        public void Push(string element)
        {
            Stack.Add(element);
            top++;
        
        }
        public string Pop() {

            string element = Stack[top];
            Stack.RemoveAt(top);
            top--;
            return element;
        
        }
        public int GetCount()
        {
            return Stack.Count;
            
        }

        //public List<string> GetStack






    }
}
