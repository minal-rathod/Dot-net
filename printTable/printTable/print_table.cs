using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printTable
{
    class print_table
    {
        public static void print_Table()
        {
            int Number;
            char ch;
            do
            { 
            Console.WriteLine("Enter the number:");
            Number = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}", Number, i, (Number * i));
                }
                Console.WriteLine("Do you want to continue??(y to continue)");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y');
        }
    }
}
