using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class decToBinary
    {
        public void decToBin()
        {
            int n, i, j, binno = 0, decNo;

            Console.Write("Convert a decimal number to binary without using array:\n");
       
            Console.Write("\n\n");
            Console.Write("Enter a number to convert : ");
            n = Convert.ToInt32(Console.ReadLine());
            decNo = n;
            i = 1;
            for (j = n; j > 0; j = j / 2)
            {
                binno = binno + (n % 2) * i;
                i = i * 10;
                n = n / 2;
            }

            Console.Write("\nThe Binary of {0} is {1}.\n\n", decNo, binno);
            Console.ReadLine();
        }
       
    }
}
