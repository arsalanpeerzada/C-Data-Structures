using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quickSort_Assignment
{
    class search
    {
        public void _search(List<int> _list,int left,int right,int loc)
        {
           

            Step2 :
            while(_list[loc]<=_list[right] && loc!=right)
            {
                right = right - 1;
            }
            if (loc==right)
            {
               // return _list[right];
            }
            if (_list[loc]>_list[right])
            {
                _list[loc] ^= _list[right];
                _list[right] ^= _list[loc];
                _list[loc] ^= _list[right];

                loc = right;
                goto Step3;

            }

            Step3 :

            while (_list[loc] > _list[left] && loc != left)
            {
                left = left + 1;
            }
            if (loc==left)
            {
               //return left;
            }
            if (_list[left]>_list[loc])
            {
                _list[loc] ^= _list[left];
                _list[left] ^= _list[loc];
                _list[loc] ^= _list[left];

                loc = left;
                goto Step2;
            }
        }
    }
}
