using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addPrime
{
    class AddingPrime
    {
        public void addingPrime()
        {
            int number = 2;
            int count = 0;
            long sum = 0;
            while (count < 500)
            {
                if (isPrimeNumber(number))
                {
                    sum += number;
                    count++;
                }
                number++;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        private static bool isPrimeNumber(int number)
        {

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

