using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace interfaceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Interface1 Bobj = new SayBye();
            p.Dontknow(Bobj);   
            Console.ReadLine();

        }
        public void Dontknow(Interface1 obj)
        {
            obj.Print();
            obj.Say();
        }

    }
   
}

