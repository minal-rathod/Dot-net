using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class MathLib
    {

        int num1;
        int num2, result;
        public int add()
        {

            try
            {
                Console.WriteLine("Enter the first number:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                num2 = Convert.ToInt32(Console.ReadLine());
                result = num1 + num2;
                Console.WriteLine(result);

            }
            catch (FormatException e)
            {
                Console.WriteLine("FormatException occurred {0}", e);
            }
            return result;
        }
        public int substract()
        {
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            result = num1 - num2;
            Console.WriteLine(result);

            object obj = new Object();
            int i;
            try
            {
                i = (int)obj;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("Caught: {0}", e);
            }

            return result;
        }
        public class DivideByOneException : Exception
        {
            public DivideByOneException(string message) : base(message)
            { }
        }
        public int multiply()
        {
        
        Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            result = num1 * num2;
            Console.WriteLine(result);
            try
            {
                if (num2 == 1)
                {
                    throw (new DivideByOneException("Divide by one exception"));
                }
            }
            catch (DivideByOneException e)
            {
                Console.WriteLine("exception caught: {0}", e);
            }

            return result;
        }
        
        public int divide()
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                num2 = Convert.ToInt32(Console.ReadLine());
                result = num1 / num2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException f)
            {
                Console.WriteLine("FormatException occurred {0}", f);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }
       

    }
 

}
