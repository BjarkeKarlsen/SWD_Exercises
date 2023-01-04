using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public class BaseDispenser : IDispenseChain
    {

        protected IDispenseChain _chain;


        public void setNext(IDispenseChain next)
        {
            this._chain = next;
        }

        public virtual void Dispense(Currency currency)
        {
            if (currency.GetAmount() < 50)
            {
                Console.WriteLine("Please take your money");
            }
            else
            {
                _chain.Dispense(currency);
            }
        }
    }

}
