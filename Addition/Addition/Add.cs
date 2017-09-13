using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition1
{
    class Add
    {
        public void Addition(int x, int y)
        {
            Console.WriteLine("the addition of two numbers is {0}",(x+y));
            Console.ReadLine();
        }
        public void Addition(int x, int y, int z)
        {
           
            Console.WriteLine("the addition of three numbers is: {0}",(x+y+z));
            Console.ReadLine();
        }
        public void Addition(int x, int y, int z, int a)
        {
         
            Console.WriteLine("the addition of four numbers is: {0}",(x+y+z+a));
            Console.ReadLine();
        }

    }
}
