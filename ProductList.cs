using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks1
{
    class Product
    {
        public int productId;
        public string name;
        public double price;
        public int quantity;
    }
    internal class ProductList
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            #region ProductAdding
            list.Add(new Product()
            {
                productId = 1,
                name = "Soap",
                price = 2000.00,
                quantity = 10

            }
           );

            list.Add(new Product()
            {
                productId = 2,
                name = "Paste",
                price = 200.00,
                quantity = 5

            }
        );



            #endregion

            #region ProductPrinting
            Console.WriteLine("Id---Name---Price---Quantity---");
            foreach (var item in list)
            {

                Console.Write(item.productId + "     ");
                Console.Write(item.name + "     ");
                Console.Write(item.price + "     ");
                Console.Write(item.quantity + "     ");
                Console.WriteLine();
            }
            #endregion

            #region Descendingorder
            var descOrderList = list.OrderByDescending(x => x.productId);
            Console.WriteLine();
            Console.WriteLine("Descending Order");
            Console.WriteLine("Id---Name---Price---Quantity---");
            foreach (var item in descOrderList)
            {

                Console.Write(item.productId + "     ");
                Console.Write(item.name + "     ");
                Console.Write(item.price + "     ");
                Console.Write(item.quantity + "     ");
                Console.WriteLine();
            }
            #endregion

            #region SelectingTwoValues
            var twoValues = from s in list select new { s.name, s.price };
            Console.WriteLine("---Name---Price---");
            foreach (var item in twoValues)
            {

                Console.Write(item.name + "   ");
                Console.Write(item.price);
                Console.WriteLine();
            }
            #endregion




            var ProductName = list.Select(x => x.name.Substring(0, 1));
            Console.WriteLine();




            Console.WriteLine();
            Console.WriteLine("The FirstName of each product in the list");

            foreach (var item in ProductName)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
