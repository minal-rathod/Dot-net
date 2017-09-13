using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Palindrome
    {
        public void checkPalindrome()
        {
            string line,reverse="";
            Console.WriteLine("Enter the string to be checked:");
            line = Console.ReadLine();
            for (int i = line.Length - 1; i >= 0; i--)
            {
                reverse += line[i].ToString();
                
            }
            if (reverse == line)
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", line, reverse);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", line, reverse);
            }
            Console.ReadLine();
        }
    }
}
