using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceProgram
{
    interface Interface1
    {
        void Print();
        void Say();
    }

    class SayHello : Interface1
    {
        public void Print()
        {
            Console.WriteLine("Hello.......");
        }
        public void Say()
        {

        }
    }
    class SayBye : Interface1
    {
        public void Say()
        {
            Console.WriteLine("Bye.....");
        }
        public void Print()
        {

        }
    }

  
}
