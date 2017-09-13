﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill
{
    class electricityBill
    {
        public void electricity_bill()
        {
            int custid, conu;
            double chg, surchg = 0, gramt, netamt;
            string connm;

            Console.Write("\n\n");
            Console.Write("Calculate Electricity Bill:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            Console.Write("Input Customer ID :");
            custid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the name of the customer :");
            connm = Console.ReadLine();
            Console.Write("Input the unit consumed by the customer : ");
            conu = Convert.ToInt32(Console.ReadLine());
            if (conu < 200)
                chg = 1.20;
            else if (conu >= 200 && conu < 400)
                chg = 1.50;
            else if (conu >= 400 && conu < 600)
                chg = 1.80;
            else
                chg = 2.00;
            gramt = conu * chg;
            if (gramt > 300)
                surchg = gramt * 15 / 100.0;
            netamt = gramt + surchg;
            if (netamt < 100)
                netamt = 100;
            Console.WriteLine("\nElectricity Bill\n");
            Console.WriteLine("Customer IDNO                       :{0}\n", custid);
            Console.WriteLine("Customer Name                       :{0}\n", connm);
            Console.WriteLine("unit Consumed                       :{0}\n", conu);
            Console.WriteLine("Amount Charges @Rs. {0}  per unit :{1}\n", chg, gramt);
            Console.WriteLine("Surchage Amount                     :{0}\n", surchg);
            Console.WriteLine("Net Amount Paid By the Customer     :{0}\n", netamt);
            Console.ReadLine();
        }
        
    }
}
