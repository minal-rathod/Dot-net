using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celciusFaren
{
    class celcius_faren
    {
        public void Celcius_faren()
        {
            Console.WriteLine("Enter the amount of celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
            Console.ReadLine();

         }
    }
}
