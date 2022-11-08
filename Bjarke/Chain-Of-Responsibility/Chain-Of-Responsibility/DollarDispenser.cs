using Chain_Of_Responsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public class DollarDispenser : DispenseChain
    {
        private DispenseChain _chain;
        private int _divider;

        public DollarDispenser(int divider)
        {
            _divider = divider;
        }

        public void setNext(DispenseChain next)
        {
            this._chain = next;
        }

        public void Dispense(Currency currency)
        {
            var amount = currency.GetAmount();

            if (amount < _divider)
            {
                _chain.Dispense(currency);
                return;
            }

            int num = (int)(amount / _divider);
            double remainder = amount % _divider;
            Console.WriteLine($"Dispensing {num} {_divider}$ note");
            if (remainder != 0) _chain.Dispense(new Currency(remainder));

        }

    }
}
