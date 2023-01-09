using System.Globalization;

namespace OOP.Classes
{
    public class BankAccount
    {
        public int Id { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        private double _Rate = 5.0; //Taxa

        public BankAccount(int id, string name)
        {
            Id = id;
            Holder = name;
        }
        public BankAccount(int id, string name, double amount) : this(id, name)
        {
            DepositMoney(amount);
        }

        public void DepositMoney(double amount)
        {
            Balance += amount;
        }

        public void WithdrawMoney(double amount)
        {
            Balance -= (amount + _Rate);
        }

        public override string ToString()
        {
            return $"\nDados da conta atualizados \n" +
                $"Conta {Id}, Titular:{Holder}, Saldo: ${Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
