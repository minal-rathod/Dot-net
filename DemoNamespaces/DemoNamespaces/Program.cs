using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Globalvar;
namespace DemoNamespaces
{
    class Program
    {
        public static int Main()
        {
            Console.WriteLine("Real main");
            Program1.demo();
            return 5;
        }
    }
}

