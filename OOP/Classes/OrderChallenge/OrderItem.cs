namespace OOP.Classes.OrderChallenge
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public ProductItem Product { get; set; }

        public OrderItem(int quantity, ProductItem product)
        {
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Product.Price;
        }
    }
}
