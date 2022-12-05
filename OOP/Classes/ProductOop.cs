using System.Globalization;
using System.Xml.Linq;

namespace OOP.Classes
{
    class ProductOop
    {
        private string _name { get; set; }
        private double _price { get; set; }
        private int _amount { get; set; }

        public ProductOop() { }
        public ProductOop(string name, double price)
        {
            _name = name;
            _price = price;
        }
        public ProductOop(string name, double price, int amount) : this(name, price)
        { // gets 2nd constructor 
            _amount = amount;
        }

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
        public double Price
        {
            get { return _price; }
        }
        public int Amount
        {

            get { return _amount; }
        }

        public double TotalValueStock()
        {
            return _price * _amount;
        }

        public void AddAmountProducts(int amount)
        {
            _amount += amount;
        }
        public void RemoveAmountProducts(int amount)
        {
            _amount -= amount;
        }

        public override string ToString()
        {
            return $"{_name}, ${_price.ToString("F2", CultureInfo.InvariantCulture)}, {_amount} unidades, Total: ${TotalValueStock().ToString("F2", CultureInfo.InvariantCulture)}";

        }

    }
}
