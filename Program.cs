using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
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

                        Console.WriteLine("The jagged array[" + i + "][" + j + "," + k + "]:" + jaggedArray1[i][j, k]);

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
            object[] traineeData = { "Srikanth", 20 };
            this.task4Print(traineeData);
        }

        public void task4Print(params object[] data)
        {
            foreach (object obj in data)
            {
                Console.WriteLine(obj);
            }
        }


        public void task5sendData(out int id, out string name, out int salary)
        {
            Console.WriteLine("Enter the employee id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of the employee");
            name = Console.ReadLine();
            Console.WriteLine("Enter the salary");
            salary = int.Parse(Console.ReadLine());



        }

        public void task5receiveData()
        {
            int id, salary;
            string name;
            int bonus;
            this.task5sendData(out id, out name, out salary);
            bonus = salary * 12 / 100;

            Console.WriteLine("***Employee Details***");
            Console.WriteLine($"Name:{name}");
            Console.WriteLine("Employee Id:" + id.ToString());
            Console.WriteLine("Employee Salary" + salary);
            Console.WriteLine("----Bonus----" + bonus);

        }

        public class day3Tasks<T>
        {
            public void sortArray(T[] arrayParam)
            {
                Array.Sort(arrayParam);
                Array.Reverse(arrayParam);
                Console.WriteLine("The SOrted Reverse Array is");
                foreach (T item in arrayParam)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();

            }

            public void Swap(T value1, T value2)
            {
                Console.WriteLine();
                Console.WriteLine("Before Swapping");
                Console.WriteLine(value1 + "\t" + value2);
                T temp = value1;
                value1 = value2;
                value2 = temp;
                Console.WriteLine("After Swapping");
                Console.WriteLine(value1 + "\t" + value2);
            }
        }

        public class day3subTask3<t1, t2, t3>
        {


            public day3subTask3(t1 a, t2 b, t3 c)
            {
                Console.WriteLine("The entered variable is " + a + "of type" + typeof(t1));
                Console.WriteLine("The 2nd variable is " + b + "of type" + typeof(t2));
                Console.WriteLine("The 3rd variable is " + c + "of type" + typeof(t3));
            }
        }

        /// <summary>
        /// task 3 of day3
        /// </summary>
        public class passingObj
        {
            public int id { get; set; }
            public string name { get; set; }

            public int age { get; set; }

            public passingObj()
            {
                Console.WriteLine("Task3");
                Console.WriteLine("Enter the name");
                name = Console.ReadLine();
                Console.WriteLine("Enter the Employee Id");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Age");
                age = int.Parse(Console.ReadLine());
            }

            public void receivingFunction(passingObj empData)
            {
                Console.WriteLine("***Employee Details***");
                Console.WriteLine("Name:" + empData.name);
                Console.WriteLine("Employee Id:" + empData.id);
                Console.WriteLine("Age:" + empData.age);


            }


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
                //day2 d2 = new day2();
                //d2.task();
                //d2.jaggedArray();
                //d2.task4();
                //d2.task5receiveData();

                //int choice;

                //Console.WriteLine("press 1 for int array");
                //Console.WriteLine("Press 2 for Character Array");
                //choice = int.Parse(Console.ReadLine());


                //switch (choice)
                //{
                //    case 1:
                //        day3Tasks<int> intObj = new day3Tasks<int>();
                //        Console.WriteLine("Enter the size");
                //        int size = Convert.ToInt32(Console.ReadLine());
                //        Console.WriteLine("Enter" + size + "numbers");
                //        int[] integerArray = new int[size];
                //        for (int i = 0; i < size; i++)
                //        {
                //            integerArray[i] = int.Parse(Console.ReadLine());
                //        }
                //        intObj.sortArray(integerArray);
                //        Console.WriteLine("Enter the 1st number");
                //        int a = int.Parse(Console.ReadLine());
                //        Console.WriteLine("Enter the 2st number");
                //        int b=int.Parse(Console.ReadLine());
                //        intObj.Swap(a, b);
                //        break;

                //    case 2:
                //        day3Tasks<char> charObj = new day3Tasks<char>();
                //        Console.WriteLine("Enter the size");
                //        int charsize = Convert.ToInt32(Console.ReadLine());
                //        Console.WriteLine("Enter" + charsize + "characters");

                //        char[] charArray = new char[charsize];
                //        for (int i = 0; i < charsize; i++)
                //        {
                //            charArray[i] = char.Parse(Console.ReadLine());
                //        }
                //        charObj.sortArray(charArray);
                //        Console.WriteLine("Enter the 1st Character");
                //        char char1 = char.Parse(Console.ReadLine());
                //        Console.WriteLine("Enter the 2st character");
                //        char char2 = char.Parse(Console.ReadLine());
                //        charObj.Swap(char1, char2);


                //        break;

                //    default:
                //        Console.WriteLine("Invalid Option:GOODBYE:!");
                //        break;
                //}

                day3subTask3<int, char, double> subTask3Obj = new day3subTask3<int, char, double>(1, 'a', 2.0d);

                ArrayList arrayList1 = new ArrayList();
                arrayList1.Add("srikanth");
                arrayList1.Add(null);
                arrayList1.Add("darshan");
                arrayList1.Add("hemanth");
                arrayList1.Add(null);
                arrayList1.Add("Arun");

                foreach (var i in arrayList1)
                {
                    var y = i ?? "I have a value";
                    Console.WriteLine(y);
                }

                passingObj obj1 = new passingObj();
                obj1.receivingFunction(obj1);


                Console.ReadLine();
            }
        }
    }
}