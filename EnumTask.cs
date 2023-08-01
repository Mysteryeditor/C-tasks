using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace tasks1
{
    internal class EnumTask
    {
        enum Shapes
        {
            
            Square,
            Circle,
            Equilateral
            
        }

        static void AreaCalculate(Shapes x,int side)
        {
            if(x== 0)
            {

                Console.WriteLine("Area of Square is=" + side * side);

            }

            else if ((int)x == 1)
            {
                Console.WriteLine("The Area of circle is" + Math.PI * Math.Pow(side, 2));

            }

            else
            {
                Console.WriteLine("The Area of Triangle is"+Math.Sqrt(3)*Math.Pow(side,2)/4);
            }

        }

        static void Main(string[] args)
        {
            #region inputGetting
            Console.WriteLine("Enter the radius/Side");
            int r=int.Parse(Console.ReadLine());
            EnumTask enumTask = new EnumTask();
            #endregion
            AreaCalculate(Shapes.Circle, r);
            AreaCalculate(Shapes.Square, r);
            AreaCalculate(Shapes.Equilateral, r);
            int[] arr = { 1, 2, 3 };
            



            Console.WriteLine("Using Looping");
            Console.WriteLine(  "Enter the side or radius");
            int side=int.Parse(Console.ReadLine());
            for(int  i = 0; i < 1; i++)
            {
               foreach (var intValue in Enum.GetValues(typeof(Shapes)))
                {
                    if ((int)intValue == 0)
                    {
                        Console.WriteLine("Area of Square is=" + side*side);
                        Console.WriteLine(Math.PI);
                    }

                    else if((int)intValue == 1)
                    {
                        Console.WriteLine("The Area of circle is" + Math.PI * Math.Pow(side, 2));
                    }

                    else
                    {
                        Console.WriteLine("The Area of Triangle is" + Math.Sqrt(3) * Math.Pow(side, 2) / 4);
                    }
                }

            }
            Console.ReadKey();

        }
    }
}
