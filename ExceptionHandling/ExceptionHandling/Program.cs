using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            MathLib pobj = new MathLib();
            Console.WriteLine("The menu is\n 1:Addition\n 2:substraction\n 3:Multiplication\n 4:Division\n\n Enter your choice");
            int c = Convert.ToInt32(Console.ReadLine());
            switch(c)
            {
                case 1:
                    Console.WriteLine("Addition of two numbers:");
                    pobj.add();
                    break;
                case 2:
                    Console.WriteLine("Substraction of two numbers:");
                    pobj.substract();
                    break;
                case 3:
                    Console.WriteLine("Multiplication of two numbers:");
                    pobj.multiply();
                    break;
                case 4:
                    Console.WriteLine("Division of two numbers:");
                    pobj.divide();
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
               }
            Console.ReadLine();
        }
    }
}
