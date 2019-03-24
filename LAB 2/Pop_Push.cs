using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Pop_Push
    {
        int popped=0;
        int pushed=0;

        public void push(int _a,List<int>b)
        {
            this.pushed=_a;
            b.Add(_a);
        }
        public void pop(List<int> b)
        {
            this.popped=b.Last();
            b.Remove(this.popped);
        }
        //public int GetCount(List<>)
        //{
            
        //    return 0;
        //}
        //public List<string> GetStack();
        //{
           
        //}

    }
}
