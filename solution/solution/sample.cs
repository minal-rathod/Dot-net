using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution
{
    class sample
    {
        class class1
        {
            public void show()
            {
                Console.WriteLine("Class1");
            }
        }
        class class2
        {
            public void show1()
            {
                Console.WriteLine("Class2");
            }
        }
        class mybase
        {
            public void show()
            {
                Console.WriteLine("show of base class");
            }
        }
        class myderived : mybase
        {

        }

        public void Sample()
        {

            mybase derivedobject = new myderived();
            mybase baseobject = new mybase();
            myderived derivedcopy1 = (myderived)derivedobject;
            //for () {
            //    object D = derivedcopy1 as object;
            //    D.show(); }
          //  myderived derivedcopy2 = (myderived)baseobject;





            int  a,b;
            a = 200000;
            b = 300000;


            if (a is int)
            {
                Console.WriteLine("A is int");
            }
            if(b is long)
            {
                Console.WriteLine("B is long");
            }
            else
            {
                Console.WriteLine("B is int");
            }


            try
            {
                int c = checked(a * b);
                Console.WriteLine(c);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception handled is {0}:",e);
            }

          
            object[] myArray = new object[6];
            myArray[0] = new class1();
            myArray[1] = new class2();
            myArray[2] = "string";
            myArray[3] = 32;
            myArray[4] = null;
            for(int i=0;i<myArray.Length;i++)
            {
                string str = myArray[i] as string;
                Console.WriteLine("{0}", i);
            }

            Console.WriteLine("\n\n\nInt:{0}",sizeof(int));
            Console.WriteLine("\nLong:{0}", sizeof(long));
            Console.WriteLine("\nfloat:{0}", sizeof(float));
            Console.WriteLine("\ndouble:{0}", sizeof(double));


            Console.WriteLine("\n\n\nInt:{0}", typeof(int));
            Console.WriteLine("\nLong:{0}", typeof(long));
            Console.WriteLine("\nfloat:{0}", typeof(float));
            Console.WriteLine("\ndouble:{0}", typeof(double));
            Console.WriteLine("\nstring:{0}", typeof(string));

            Console.WriteLine("\n{0}", 2 * 3 + 4);

            long val = 55000000;
            int j = checked((int)val);
            Console.WriteLine("{0},{1}", j, val);

            int l = 20;
            object o = l;
            int k = (int)o;
            Console.WriteLine("\n{0}",k);

            class1 x, y;
            x = new class1();
            y = new class1();

            bool z = ReferenceEquals(x, y);
            bool q = ReferenceEquals(null,null);
            bool r = ReferenceEquals(y, x);
            Console.WriteLine(z);
            Console.WriteLine(q);
            Console.WriteLine(r);
        }
       
       

    }
}
