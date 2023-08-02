using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks1
{
    internal class PrintingValues
    {

        public string name;

        public unsafe void valuePrinting()
        {

            int id = 10;
            int* idAddress = &id;
            string name = "Srikanth";
            //string* nameAddress = &name;

            Console.WriteLine($"The id{id} is stored at the address {(int)&id}");
            //Console.WriteLine($"The name{name} is stored at the address {&name}");



        }
    }


    internal class PointersTask
    {

        public static void Swapping()
        {
            int n1 = 10;
            int n2 = 20;
            Console.WriteLine($"Before Swapping a={n1},b={n2}");

            unsafe
            {
                int* ptr1 = &n1;
                int* ptr2 = &n2;

                *ptr1 = *ptr1 + *ptr2;
                *ptr2 = *ptr1 - *ptr2;
                *ptr1 = *ptr1 - *ptr2;
            }

            Console.WriteLine($"After Swapping a={n1},b={n2}");

        }
    }

    public class PointersAddition
    {


        public static void Addition()
        {
            int a11=10;
            int a12=20;
            int a21=30;
            int a22=31;
            unsafe
            {
                int[] array1 = { a11,a12,a21,a22 };
                int[] array2 = { a11, a12, a21, a22 };

 
                int* a11Add = &a11;
                int* a12Add = &a12;
                int* a21Add = &a21;
                int* a22Add = &a22;
                int[] sumArray=new int[array1.Length];

                fixed (int* ptr3 = array1)
                fixed (int* ptr4 = array2) 
                
                        for(int i=0; i<array1.Length; i++)
                    {

                        
                    }

                for(int i=0 ; i<array2.Length ; i++)
                {
                    Console.WriteLine(sumArray[i]);
                    
                }
            }
        
        
        }
    }

    public class PointersExecution
    {
        static void Main(string[] args)
        {
            PointersTask.Swapping();
            PointersAddition.Addition();
            Console.ReadKey();

        }

    }
}
