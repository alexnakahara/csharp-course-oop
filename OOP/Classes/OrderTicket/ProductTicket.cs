using System.Globalization;

namespace OOP.Classes.OrderTicket
{
    public class ProductTicket
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductTicket() { }

        public ProductTicket(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return $"{Name} ${Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
