using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
 
    class VehicleClass
    {
        public void drive()
        {
            Console.WriteLine("Common feature of driving");
        }
    }
   
    class Car : VehicleClass
    {
        
        public void car()
        {
            Console.WriteLine("Renault,BMW,Audi,etc are famous brands for cars.");
        }
    }
    class Bike : VehicleClass
    {

        public void bike()
        {
            Console.WriteLine("Harley-Davidson,Honda,Hero,etc are famous brands for bikes.");
        }
    }
    class Cycle : VehicleClass
    {
        public void cycle()
        {
            Console.WriteLine("Trek,Specialized,Scott Bicycle,Cannondale,etc are famous brands for cycles.");
        }
    }
}

