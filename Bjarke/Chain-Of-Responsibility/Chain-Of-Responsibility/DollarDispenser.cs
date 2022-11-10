using Chain_Of_Responsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public class DollarDispenser : BaseDispenser
    {
        private int _divider;

        public DollarDispenser(int divider)
        {
            _divider = divider;
        }

        public override void Dispense(Currency currency)
        {
            var amount = currency.GetAmount();

            if (amount >= _divider && amount % 50 == 0)
            {
                int num = (int)(amount / _divider);
                double remainder = amount % _divider;
                Console.WriteLine($"Dispensing {num} {_divider}$ note");
                base.Dispense(new Currency(remainder));
            }
            else
            {
                base.Dispense(currency);
            }
        }

    }
}
