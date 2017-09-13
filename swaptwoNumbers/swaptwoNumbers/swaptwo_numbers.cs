using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swaptwoNumbers
{
    class swaptwo_numbers
    {
        public void Swap()
        {
            int firstnum, secondNum, temp;
            char ch;
            do
            {
                Console.WriteLine("Enter the first number:");
                firstnum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                secondNum = Convert.ToInt32(Console.ReadLine());
                temp = firstnum;
                firstnum = secondNum;
                secondNum = temp;
                Console.WriteLine("The first number now is {0}",firstnum);
                Console.WriteLine("The second number now is {0}", secondNum);
                Console.WriteLine("Do you want to continue??(y to continue)");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y');
         
        }
    }
}
