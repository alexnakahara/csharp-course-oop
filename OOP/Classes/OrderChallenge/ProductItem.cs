namespace OOP.Classes.OrderChallenge
{
    public class ProductItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductItem(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
