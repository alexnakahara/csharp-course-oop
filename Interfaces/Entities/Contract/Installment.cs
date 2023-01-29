using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities.Contract
{
    class Installment
    {
        public DateTime DuoDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime duoDate, double amount)
        {
            DuoDate = duoDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DuoDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
                + " - $"
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
