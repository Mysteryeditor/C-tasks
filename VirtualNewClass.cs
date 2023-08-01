using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks1
{
    class Employee
    {
        public int id;
       public  string name;
        public double salary;

     

        public void Details()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Id:" + id);
            Console.WriteLine("Salary:" + salary);
        }
    }

    class Hr : Employee
    {
        public float bonus;

      

        public new void Details()
        {
            Console.WriteLine("The Salary With Bonus is"+(salary+bonus));
        }

    }
    internal class VirtualNewClass
    {
    

        static void Main(string[] args)
        {
          
            Hr emp1 = new Hr()
            {
                
                id = 1,
                name = "Srikanth",
                salary = 10000,
                bonus=2000

            };
            Employee emp2 = emp1;
            emp2.Details();
            emp1.Details();
            
            Console.ReadKey();

        }
    }
}
