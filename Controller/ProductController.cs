using System;
using System.Collections.Generic;
using ConsoleApp3.entity;

namespace ConsoleApp3.Controller
{
    public class ProductController
    {
        List<Product> list = new List<Product>();

        public bool AddProduct()
        {
            Console.WriteLine("Please enter ProductId: ");
            string productId = Console.ReadLine();
            Console.WriteLine("Please enter ProductName: ");
            string productName = Console.ReadLine();
            Console.WriteLine("Please enter Price: ");
            decimal price = Decimal.Parse(Console.ReadLine());
            Product product = new Product(productId, productName, price);
            list.Add(product);
            return true;
        }

        public void DisplayProduct()
        {
            Console.WriteLine("{0, -20} {1, -20} {2, -20}", "Product ID", "Product Name", "Price");
            Console.WriteLine("----------------------------------------------------------------------------");
            foreach (var a in list)
            {
                Console.WriteLine("{0, -20} {1, -20} {2, -20}", a.ProductId, a.ProductName, a.Price);
            }
        }

        public void DeleteProduct()
        {
            Console.WriteLine("Delete Success");
            string id = Console.ReadLine();
            Product idDelete = list.Find(a => a.ProductId == id);
            list.Remove(idDelete);
        }
    }
}