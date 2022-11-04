using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public class Currency
    {
        private double _amount;
        private string? _currency;

        public Currency( double amount)
        {
            _amount = amount;
        }

        public string GetCurrency()
        {
            return _currency;

        }
        public double GetAmount()
        {
            return _amount;
        }
    }
}
