using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace replaceWhitespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            do {
                Console.WriteLine("Enter the string with many whitespaces:");
                string str = Convert.ToString(Console.ReadLine());
                string pattern = "\\s+";
                string replacement = " ";
                Regex rgx = new Regex(pattern);
                string result = rgx.Replace(str, replacement);
                Console.WriteLine("Original String: {0}", str);
                Console.WriteLine("Replacement String: {0}", result);
                Console.ReadLine();
                Console.WriteLine("Do you want to continue?(y to continue)");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch=='y');
        }

    }
}
