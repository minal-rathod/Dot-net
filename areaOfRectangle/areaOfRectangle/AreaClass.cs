using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaOfRectangle
{
    static class AreaClass
    {
       public static void areaRectangle()
        {
            char ch;
            int length, breadth;
            do
            {
                Console.WriteLine("Enter the length of rectangle");
                length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the breadth of rectangle");
                breadth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Area of rectangle is {0}",(length*breadth));
                Console.WriteLine("Do you want to continue?(y to continue)");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y');
        }
    }
}
