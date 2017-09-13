using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multithreding
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread obj1Thread = new Thread(Function1);
            Parallel.Invoke(Function1, Function2);
            obj1Thread.Start();
           
            Console.WriteLine("Main thread exited");
        }
        static void Function1()
        {
            Console.WriteLine("Function 1 entered");
            Console.ReadLine();
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine(i); 
            }
            Thread obj2Thread = new Thread(Function2);
            obj2Thread.Start();
            Console.WriteLine("Function 1 exited");
        }
        static void Function2()
        {
            Console.WriteLine("Function 2 entered");
            Console.ReadLine();
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Function 2 exited");
            Console.ReadLine();
        }
    }
}
