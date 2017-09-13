using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interFaceVehicle
{
    interface InterfaceVehicle
    {
        void drive();
        void car();
        void bike();
        void cycle();
    }

    class Car : InterfaceVehicle
    {
       public void drive()
        {
            Console.WriteLine("Cars: Common feature of driving");
        }
        public void car()
        {
            Console.WriteLine("Renault,BMW,Audi,etc are famous brands for cars.");
        }
        public void bike() { }
        public void cycle() { }
    }
    class Bike : InterfaceVehicle
    {
        public void drive()
        {
            Console.WriteLine("Bike:Common feature of driving");
        }
       
        public void bike()
        {
            Console.WriteLine("Harley-Davidson,Honda,Hero,etc are famous brands for bikes.");
        }
        public void car() { }
        public void cycle() { }
    }
    class Cycle : InterfaceVehicle
    {
        public void drive()
        {
            Console.WriteLine("Cycle:Common feature of driving");
        }
       
        public void cycle()
        {
            Console.WriteLine("Trek,Specialized,Scott Bicycle,Cannondale,etc are famous brands for cycles.");
        }
        public void bike() { }
        public void car() { }
    }
}
