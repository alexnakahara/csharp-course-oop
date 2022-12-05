using System.Globalization;

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

        #region Getters and setters
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            if (name != null && name.Length > 1)
            {
                _name = name;
            }
        }
        public double GetPrice()
        {
            return _price;
        }
        public int GetAmount()
        {
            return _amount;
        }

        #endregion
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
