using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempMessage
{
    class TempMsg
    {
        public void temp_msg()
        {
            int tmp;
            Console.Write("\n\n");
            Console.Write("Accept a temperature in centigrade and display a suitable message:\n");
            Console.Write("--------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input day's temperature : ");
            tmp = Convert.ToInt32(Console.ReadLine());
            if (tmp < 0)
                Console.Write("Freezing weather.\n");
            else if (tmp < 10)
                Console.Write("Very cold weather.\n");
            else if (tmp < 20)
                Console.Write("Cold weather.\n");
            else if (tmp < 30)
                Console.Write("Normal in temp.\n");
            else if (tmp < 40)
                Console.Write("Its Hot.\n");
            else
                Console.Write("Its very hot.\n");
            Console.ReadLine();
        }
    }
}
