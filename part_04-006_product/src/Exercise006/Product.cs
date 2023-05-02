namespace Exercise006
{
    using System;
    public class Product
    {
        private double price;
        private int quantity;
        private string name;
        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public void PrintProduct()
        {
            Console.WriteLine(this.name + ": price " + this.price + ": " + this.quantity + " pcs");
        }

    }
}