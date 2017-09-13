using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace semaphore
{
    class Program
    {
        static Semaphore s1 = null;
        static void Main(string[] args)
        {
            try
            {
                s1 = Semaphore.OpenExisting("synchronizationMechanism");
            }
            catch(Exception e)
            {
                s1 = new Semaphore(2, 2, "synchronizationMechanism");
            }
            Console.WriteLine("Yet to get the control");
            s1.WaitOne();
            Console.WriteLine("Permitted for the access.");
            Console.ReadLine();
            s1.Release();
        }
    }
}
