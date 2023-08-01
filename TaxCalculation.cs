using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks1
{
    internal abstract class TaxCalculation
    {
        public abstract void tax(double salary);
    }

    internal class HighSalary : TaxCalculation
    {
        public override void tax(double salary)
        {
            double tax = salary * 12 / 100;
            Console.WriteLine("You have to Pay Rs." + tax);

        }
    }

    internal class MediumSalary : TaxCalculation
    {
        public override void tax(double salary)
        {
            double tax = salary * 10 / 100;
            Console.WriteLine("You have to Pay Rs." + tax);
        }
    }

    internal class LowSalary : TaxCalculation
    {
        public override void tax(double salary)
        {
            double tax = salary * 8 / 100;
            Console.WriteLine("You have to Pay Rs." + tax);
        }
    }



    internal class Execution
    {
        static void Main(string[] args)
        {
            TaxCalculation taxCalculation;
            Console.SetWindowSize(100, 100);

            Console.WriteLine("***Tax Calculation***");
            Console.WriteLine("Enter Your Salary:");
            double salary = Convert.ToDouble(Console.ReadLine());
            if (salary > 20000)
            {
                taxCalculation = new HighSalary();
                taxCalculation.tax(salary);
            }

            else if (salary < 19999 && salary > 10999)
            {
                taxCalculation = new MediumSalary();
                taxCalculation.tax(salary);
            }

            else
            {
                taxCalculation = new LowSalary();
                taxCalculation.tax(salary);
            }
            Console.Beep();
            while (Console.ReadKey().Key!=ConsoleKey.A) ;
        }

    }


}
