using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericSample
{
    class Program
    {
        static void Main(string[] args)
        {
            swapClass<int> sobj = new swapClass<int>();
            int x = 1000;
            int y = 2000;
            sobj.swap(ref x, ref y);
            Console.ReadLine();
        }
    }
}
