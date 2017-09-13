using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bird
{
    class Bird
    {
       public void walk()
        {
            Console.WriteLine("Bird can walk");
            Console.ReadLine();
        }
    }

    class Bird1 : Bird
    {
        public void fly()
        {
            Console.WriteLine("Bird can Fly");
            walk();
            Console.ReadLine();
        }
    }

    class Bird2 : Bird
    {
        public void sing()
        {
            Console.WriteLine("Bird can sing");
            walk();
            Console.ReadLine();
        }
    }
}
