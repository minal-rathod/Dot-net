using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericSample
{
    class swapClass<T>
    {
        public void swap(ref T x,ref T y)
        {
            Console.WriteLine("Before swap:{0},{1}",x,y);
            T temp = x;
            x = y;
            y = temp;
            Console.WriteLine("After swap:{0},{1}", x, y);
        }
    }
}
