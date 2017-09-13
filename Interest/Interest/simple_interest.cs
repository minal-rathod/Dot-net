using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Interest
{        //Declare the delegate
        public delegate void CalculateSimpleInterest();
        public delegate void CalculateSimpleInterest2(string s);
    class simple_interest
        {
            public static void getTotalInterest()
            {
                int interest; int princamt; int year; int rate;
                Console.WriteLine("enter the principle amount:");
                princamt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the number of years:");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the rate of interest:");
                rate = Convert.ToInt32(Console.ReadLine());

                interest = princamt * year * rate / 100;
                Console.WriteLine("The interest amount is {0}", interest);
        
                
             }
            public static void getInterestRatePerYear()
            {
            Console.WriteLine("enter the interest:");
            int interest = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInterest per year is {0}", (interest / 12));

             }
            public static void PrintText()
            {
                Console.WriteLine("Text Printed with the help of Action");
                getTotalInterest();
            }

            public static int ShowNumber()
            {
                Console.WriteLine("Text Printed with the help of Function");
                getTotalInterest();
                return 0;
             }


        public static void Main()
            {
           // Instantiation
           CalculateSimpleInterest d0 = new CalculateSimpleInterest(getTotalInterest);
            d0 += new CalculateSimpleInterest(getInterestRatePerYear);
            //Invoke.........
            d0();
            //Action and function............
            Action printText = new Action(simple_interest.PrintText);
            Func<int> random = new Func<int>(simple_interest.ShowNumber);
            PrintText();
            int randomNumbers = random();
            Console.WriteLine("Random Number is: {0}", randomNumbers);
            //Anonymous method...........
            CalculateSimpleInterest2 d1 = delegate (string s)
            {
                Console.WriteLine("Hello {0} ....",s);
                getTotalInterest();

            };
            d1("Minal");

            //Lambda expressions.........

            CalculateSimpleInterest2 d2 = n =>
            {
                Console.WriteLine(string.Format("Hello {0} from lambda method", n));
                getTotalInterest();
            };

            d2("Minal");
            Console.ReadLine();
        }



    }
    }





       
