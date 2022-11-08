using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Chain_of_responsibility;

namespace Chain_of_responsibility
{
    public class DollarDispenser : IDispenseChain 
    {
        private IDispenseChain _nextChain;
        private int _divider;

        public DollarDispenser(int divider)
        {
            _divider = divider;
        } 


        public void Dispense(Currency cur)
        {
            
                if (cur.GetAmount() >= _divider)
                {
                    int num = cur.GetAmount() / _divider;
                    int remainder = cur.GetAmount() % _divider;
                    Console.WriteLine("Dispensing " + num + " " + _divider + "DKK note");
                    if (remainder != 0) this._nextChain.Dispense(new Currency(remainder));
                }
                else
                {
                    this._nextChain.Dispense(cur);
                }
            
            
        }

        public void SetNextChain(IDispenseChain nextChain)
        {
            this._nextChain = nextChain;
        }
    }
}

