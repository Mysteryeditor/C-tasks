using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks1
{
    interface IOne
    {
        float radius { get; set; }
        public  void Area();
    }

    interface ITwo
    {
        float length { get; set; }
        float width { get; set; }

        public void Area();
    }
    internal class TwoInterfaces : IOne, ITwo
    {
        public float length { get; set; }
        public float width { get; set; }
        public float radius { get; set; }
        void IOne.Area()
        {
            Console.WriteLine("The area of the circle is "+(Math.PI*Math.Pow(radius,2)));
        }

        void ITwo.Area()
        {
            Console.WriteLine("The Area Of Rectangle is"+width*length);

        }

    }

    internal class TwoInterfacesExecution
    {
        static void Main(string[] args)
        {
            IOne one ;
            one = new TwoInterfaces();
            one.radius = 10;
            one.Area();

            ITwo two;
            two = new TwoInterfaces();
            two.length = 10;
            two.width = 10;
            two.Area();
            Console.ReadKey();
        }
    }
}
