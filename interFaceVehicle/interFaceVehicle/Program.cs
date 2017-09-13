using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interFaceVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
       
                char ch;
                Console.WriteLine("Vehicle types are:\n 1. Car \n 2. Bike \n 3.Cycle");
                do
                {
                    Console.WriteLine("Enter the choice:");
                    int c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                        InterfaceVehicle Vobj = new Car();
                            Vobj.drive();
                            Vobj.car();
                            break;
                        case 2:
                        InterfaceVehicle V1obj = new Bike();
                            V1obj.drive();
                            V1obj.bike();
                            break;
                        case 3:
                        InterfaceVehicle V2obj = new Cycle();
                            V2obj.drive();
                            V2obj.cycle();
                            break;
                        default:
                            Console.WriteLine("Entered wrong choice");
                            break;
                    }
                    Console.WriteLine("Do you want to continue?(y to continue)");
                    ch = Convert.ToChar(Console.ReadLine());
                } while (ch == 'y');
            }
        }
    }
