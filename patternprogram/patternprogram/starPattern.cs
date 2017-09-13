using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternprogram
{
    class starPattern
    {
        int i, j;
        int val;
        public void star()
        {
            Console.WriteLine("Enter the number of lines to be printed:");
            val = Convert.ToInt32(Console.ReadLine());
            for (i = val; i >= 0; i--)
            {
                for (j = 0; j < val; j++)
                {
                    if (i > j)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
