using System.Globalization;


namespace OOP.Classes
{
    class ProductOop
    {
        private string _name { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }
        public double Price { get; private set; }
        public int Amount { get; private set; }

        public ProductOop() { }
        public ProductOop(string name, double price)
        {
            _name = name;
            Price = price;
        }
        public ProductOop(string name, double price, int amount) : this(name, price)
        { // gets 2nd constructor 
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
            return $"{_name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}, {Amount} unidades, Total: ${TotalValueStock().ToString("F2", CultureInfo.InvariantCulture)}";
                
        }

    }
}
