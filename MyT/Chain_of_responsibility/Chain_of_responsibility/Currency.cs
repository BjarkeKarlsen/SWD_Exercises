using System;
namespace Chain_of_responsibility
{
    public class Currency
    {
        private int _amount;

        public Currency(int amt)
        {
            _amount = amt;
        }

        public int GetAmount()
        {
            return _amount;
        }
    }
}

