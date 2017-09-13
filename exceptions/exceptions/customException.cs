using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    class customException
    {
        public class DivideByOneException : Exception
        {
            public DivideByOneException(string message) : base(message)
            { }
        }
        
        int num1, num2, result;
        public void divide()
        {
            Console.WriteLine("Enter the numbers:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
           try {
                if (num2 == 1)
                {
                    throw (new DivideByOneException("Divide by one exception"));

                    result = num1 / num2;
                }
            }
            catch (DivideByOneException e)
            {
                Console.WriteLine("exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result is {0}", result);
            }
            Console.ReadLine();
        }

    }
}

