using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace synchronizationMechanism
{
    class Program
    {
        static void Main(string[] args)
        {
            Program fobj = new Program();
            Thread obj1Thread = new Thread(fobj.Function1);
            obj1Thread.Start();
            //Thread obj2Thread = new Thread(fobj.Function1);
            //obj2Thread.Start();
            Console.WriteLine("Main thread exited");
        }
        public void Function1()
        {
            using (var m1 = new Mutex(false, "synchronizationMechanism"))
            {
                if (!m1.WaitOne(10000, false))
                {
                    //Monitor.Enter(this);
                    Console.WriteLine("Function 1 entered");
                    Console.ReadLine();

                    //Monitor.Exit(this);
                }
                Console.WriteLine("Function 1 exited");
                Console.ReadLine();

            }
        }
  
    }
}
