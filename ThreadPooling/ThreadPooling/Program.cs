using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPooling
{
    class Minal
    {
        public int id;
        public Minal(int _id)
        {
            id = _id;
        }
    }
    class Function1
    {
        
        public void func1(Minal Id)
        {
            Console.WriteLine("Function 1 entered");
            ThreadPool.QueueUserWorkItem(Function2, Id);
            Console.WriteLine("Function 1 exited");
        }
        static void Function2(Object obj)
        {
            Console.WriteLine("Function 2 entered");
            Console.WriteLine("Thread {0} consumes {1}", Thread.CurrentThread.GetHashCode(), ((Minal)obj).id);
            Thread.Sleep(100);
            Console.WriteLine("Function 2 exited");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************MAIN****************");
            Function1 obj = new Function1();
            obj.func1(new Minal(1));
       
            Console.WriteLine("Thread {0}",Thread.CurrentThread.GetHashCode()); //{0}
           
            Console.Read();
        }

    }
}
