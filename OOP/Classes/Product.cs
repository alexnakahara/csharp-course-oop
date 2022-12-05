using System.Globalization;

namespace OOP.Classes
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; } 
        public int Amount { get; set; } 

        public Product() { }    
        public Product(string name, double price, int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }   

        public double TotalValueStock()
        {
            return Price * Amount;
        }

        public void AddAmountProducts(int amount)
        {
            Amount += amount;
        }
        public void RemoveAmountProducts(int amount)
        {
            Amount -= amount;
        }

        public override string ToString()
        {
            return $"{Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}, {Amount} unidades, Total: ${TotalValueStock().ToString("F2", CultureInfo.InvariantCulture)}";

        }

    }
}
