﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parallelProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 100000, x => Function1());
            Console.ReadLine();
        }
        static void Function1()
        {
           
            for(int i = 0; i <= 100000; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
