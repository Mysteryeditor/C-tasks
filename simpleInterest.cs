using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks1
{
    internal class simpleInterest
    {
      
        static void Main(string[] args)
        {
            var si = (double p, int n, float r) =>
            {
                double interest=p*n*r/100;
                Console.WriteLine("The SImple Interest is Rs." + interest);
            };
            Console.WriteLine("***SI Calculation");
            Console.WriteLine("Enter the Principle AMount");
            double principle=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Time Period");
            int years=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate");
            float rate=float.Parse(Console.ReadLine());
            si(principle, years, rate);


            Console.ReadKey();

        }
    }
}
