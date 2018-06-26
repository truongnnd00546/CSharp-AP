using System;
using System.Collections.Generic;
using ConsoleApp3.Controller;
using ConsoleApp3.entity;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductController _product = new ProductController();
            while (true)
            {
                Console.WriteLine("-----------PRODUCT MANAGER-----------");
                Console.WriteLine("1. Add product records");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product records");
                Console.WriteLine("4 Exit");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Please enter your choice: ");
                var choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        _product.AddProduct();
                        break;
                    case 2:
                        _product.DisplayProduct();
                        break;
                    case 3:
                        _product.DeleteProduct();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            }
        }
    }
}