using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Tyre
    {
        public void TyreType()
        {
            Console.WriteLine("Tubeless tyre");
        }
    }

    public class Scooter : Tyre
    {
        public void ScooterType()
        {
            Console.WriteLine("Scooter color is black");
            TyreType();
        }
    }

    public class Car : Tyre
    {
        public void CarType()
        {
            Console.WriteLine("Car color is Red");
            TyreType();
        }
    }
}
