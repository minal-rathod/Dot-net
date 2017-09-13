using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace empDetail
{
    class emplClass
    {
        public void regex()
        {
            char ch;
            do
            {
                Console.WriteLine("Enter the phone number:");
                string pnumber = Convert.ToString(Console.ReadLine());
                string check_num = @"^\d{3}-\d{4}$";
                // Compile the regular expression.
                Regex r = new Regex(Convert.ToString(check_num));
                // Match the regular expression pattern against a pnumber string
                Match m = r.Match(Convert.ToString(pnumber));
                if (m.Success)
                {
                    // Display the first match and its capture set.
                    Console.WriteLine("Matched! Correct format");
                }
                else
                {
                    Console.WriteLine("Incorrect format");
                }
                Console.WriteLine("Do you want to continue?(y to continue)");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y');
        }
    }
}
