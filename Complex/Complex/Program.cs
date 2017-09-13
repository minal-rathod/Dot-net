using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the name of employee:");
            Employee Mobj = new Manager();
            Mobj.display();
            Mobj.calculate();
           

        }
    }
}
