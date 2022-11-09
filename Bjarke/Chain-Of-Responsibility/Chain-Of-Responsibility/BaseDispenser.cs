using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public class BaseDispenser : DispenseChain
    {

        protected DispenseChain? _chain;


        public void setNext(DispenseChain next)
        {
            this._chain = next;
        }

        public virtual void Dispense(Currency currency)
        {
            if (currency.GetAmount() % 50 != 0)
            {
                Console.WriteLine("Amount cannot be dispense");
            }
            else if (currency.GetAmount() < 50)
            {
                Console.WriteLine("Stop dispensing");
            }
            else
            {
                _chain.Dispense(currency);
            }
        }
    }

}
