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

        public Currency(double amount)
        {
            _amount = amount;
        }

        public double GetAmount()
        {
            return _amount;
        }
    }
}
