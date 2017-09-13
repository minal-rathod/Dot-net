using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    class Program
    {
        class data { };
        static void Main(string[] args)
        {
            ArrayList AL = new ArrayList();
            int x = 10;
            string m = "Minal" ;
            int y = 20;
            data dobj = new data();
            AL.Add(x);
            AL.Add(m);
            AL.Add(y);
          //  AL.Add(dobj);

            Console.WriteLine("Contents of the arraylist:");
            foreach(object o in AL)
            {
                Console.WriteLine(o.ToString());
            }
            Console.ReadLine();
            Console.WriteLine("Last element is removed:");
            AL.Remove(dobj);
            foreach (object o in AL)
            {
                Console.WriteLine(o.ToString());
            }
            Console.ReadLine();
            Console.WriteLine("List is updated:");
            AL.Insert(1,y);
            foreach (object o in AL)
            {
                Console.WriteLine(o.ToString());
            }
            Console.ReadLine();
        }
        
    }
}
