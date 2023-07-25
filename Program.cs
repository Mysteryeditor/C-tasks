using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class task2
    {
        StringBuilder testString = new StringBuilder("Hello!!!");
        public void stringOperations()
        {
            testString.AppendLine("Welcome ALL");
            Console.WriteLine(testString.ToString());

            testString.Append("Guys");
            Console.WriteLine(testString.ToString());

            testString.Insert(0, "hi");
            Console.WriteLine(testString.ToString());

            testString.Remove((testString.Length - 17), 17);
            Console.WriteLine(testString.ToString());

            testString.Replace('!', '?');
            Console.WriteLine(testString.ToString());

        }

        void internalClassMethod()
        {
            Console.WriteLine("This resides under an internal class");

        }




    }

    public class task3
    {
        public static void publicMethod()
        {
            Console.WriteLine("This resides inside a public class");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {//1.Getting the list of trainees
            Console.WriteLine("Enter the count of trainees");
            int count = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Enter " + count + " trainees");
            for (int i = 0; i < count; i++)
            {
                sb.AppendLine(Console.ReadLine());
            }
            Console.WriteLine("The Entered Trainees are:");
            Console.WriteLine(sb.ToString());

            //task2:
            task2 t2 = new task2();
            t2.stringOperations();
            Console.ReadLine();
        }
    }
}
