using System;

namespace ProductInventoryApp
{
    public class Product
    {
        // Properties
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        // Constructor
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // Add stock
        public void AddStock(int amount)
        {
            Quantity += amount;
            Console.WriteLine($"{amount} units added. New stock: {Quantity}");
        }

        // Sell stock
        public void Sell(int amount)
        {
            if (amount <= Quantity)
            {
                Quantity -= amount;
                Console.WriteLine($"{amount} units sold. Remaining stock: {Quantity}");
            }
            else
            {
                Console.WriteLine("Not enough stock to sell!");
            }
        }

        // Display details
        public override string ToString()
        {
            return $"Product: {Name}, Price: {Price}, Stock: {Quantity}";
        }
    }
}
