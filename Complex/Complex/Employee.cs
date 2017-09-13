using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    public abstract class Employee
    {
        public int sal = 1000;
        public abstract void calculate();
        public virtual void display()
        { }
        public Employee()
        { }

    }

    class Developer: Employee
    {
        
        public override void calculate()
        {
            sal = sal * 4;
            Console.WriteLine("Salary of Developer is : {0}", sal);
        }
        public override void display()
        {
            string name = Console.ReadLine();
            Console.WriteLine("The employee name is {0}",name);
            Console.ReadLine();
        }
    }

    class Salesman : Employee
    {
        public override void calculate()
        {
            sal = sal * 2;
            Console.WriteLine("Salary of Salesman is : {0}", sal);
        }
        public override void display()
        {
            Console.WriteLine("Enter the information of employee:");
            Console.ReadLine();
            string name, designation;
            name = Console.ReadLine();
            designation = Console.ReadLine();
            Console.WriteLine("The name of employee is {0} and Designation is {1}", name, designation);
        }
    }

    class Manager : Employee
    {
        public override void display()
        {
            string name = Console.ReadLine();
            Console.WriteLine("The employee name is {0}", name);
        }

        public override void calculate()
        {
            sal = sal * 5;
            Console.WriteLine("Salary of Manager is : {0}", sal);
            Console.ReadLine();
        }
       
    }
}
