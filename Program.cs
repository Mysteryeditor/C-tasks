using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class task2
    {
        int cd;
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

    public class day2
    {
        int rows = 0, cols = 0;


        public void task()
        {
            Console.WriteLine("Enter the number of rows");
            rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns");
            cols = int.Parse(Console.ReadLine());


            int[,] array1 = new int[rows, cols];
            int size = rows * cols;
            int[] oneDarray = new int[size];//one dimensional array
            Console.WriteLine("Enter " + size + " elements one by one");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("+++The 2D array+++");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array1[i, j] + "     ");

                }
                Console.WriteLine();
            }

            //coverting into 1 d array task2
            int indexOneD = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    oneDarray[indexOneD++] = array1[i, j];
                }
            }

            Console.WriteLine("The same array in One Dimension");
            foreach (int element in oneDarray)
            {
                Console.Write(element + " ");
            }
        }

        public void jaggedArray()
        {
            int[][,] jaggedArray1 =  {
            new int[,]{ { 1,2} },
            new int[,]{{3,4} }
            };

            for (int i = 0; i < jaggedArray1.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < jaggedArray1[i].GetLength(x); j++)
                {
                    for (int k = 0; k < jaggedArray1[j].Rank; k++)

                        Console.WriteLine("The jagged array["+i+"]["+j+","+k+"]:"+jaggedArray1[i][j, k]);
                   
                    //for(int k = 0; k < jaggedArray1[J][j].Length; k++)
                    //{
                    //    Console.WriteLine(jaggedArray1[k]);
                    //}
                }
                x++;
                Console.WriteLine();
            }

        }


        public void task4()
        {
            object[] traineeData = {"Srikanth",20 };
            this.task4Print(traineeData);
        }

        public void task4Print(params object[] data)
        {
            foreach (object obj in data)
            {
                Console.WriteLine(obj);
            }
        }

       
        public void task5sendData(out int id,out string name,out int salary)
        {
            Console.WriteLine("Enter the employee id");
            id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of the employee");
            name=Console.ReadLine();
            Console.WriteLine("Enter the salary");
            salary=int.Parse(Console.ReadLine());



        }

        public void task5receiveData()
        {
            int id, salary;
            string name;
            int bonus;
            this.task5sendData(out id,out name,out salary);
            bonus = salary * 12 / 100;

            Console.WriteLine("***Employee Details***");
            Console.WriteLine($"Name:{name}");
            Console.WriteLine("Employee Id:" + id.ToString());
            Console.WriteLine("Employee Salary" + salary);
            Console.WriteLine("----Bonus----" + bonus);

        }
        internal class Program
        {
            static void Main(string[] args)
            {//1.Getting the list of trainees
             //Console.WriteLine("Enter the count of trainees");
             //int count = Convert.ToInt32(Console.ReadLine());
             //StringBuilder sb = new StringBuilder();
             //Console.WriteLine("Enter " + count + " trainees");
             //for (int i = 0; i < count; i++)
             //{
             //    sb.AppendLine(Console.ReadLine());
             //}
             //Console.WriteLine("The Entered Trainees are:");
             //Console.WriteLine(sb.ToString());

                ////task2:
                //task2 t2 = new task2();
                //t2.stringOperations();



                //day2 tasks

                day2 d2 = new day2();
                d2.task();
                d2.jaggedArray();
                d2.task4();
                d2.task5receiveData();
                Console.ReadLine();
            }
        }
    }
}