using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubeofIntegers
{
    class cubeOfInteger
    {
       public void Cube_integer()
        {
            int i, input;
            Console.Write("\n\n");
            Console.Write("Display the cube of the number:\n");
            Console.Write("---------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of terms : ");
            input = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= input; i++)
            {
                Console.Write("Number is : {0} and cube of the {1} is :{2} \n", i, i, (i * i * i));
            }
            Console.ReadLine();
        }

}
}
