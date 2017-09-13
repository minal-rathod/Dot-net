using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfDigits
{
    class Sum_Digit
    {
        public void sum_digit()
        {
            int num, temp, digit, sum = 0;

            Console.WriteLine("Enter the number \n");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                digit = num % 10;
                sum = sum + digit;
                num /= 10;
            }
           Console.WriteLine("Given number = {0}\n", temp);
            Console.WriteLine("Sum of the digits {0} = {1}\n", temp, sum);
            Console.ReadLine();
        }
    }
}
