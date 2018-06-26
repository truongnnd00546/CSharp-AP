﻿namespace ConsoleApp3.entity
{
    public class Product
    {
        private string productId;
        private string productName;
        private decimal price;

        public Product()
        {
        }

        public Product(string productId, string productName, decimal price)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
        }

        public string ProductId
        {
            get => productId;
            set => productId = value;
        }

        public string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public decimal Price
        {
            get => price;
            set => price = value;
        }
    }
}