using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Chain_of_responsibility;

namespace Chain_of_responsibility
{
    public class Bill100Dispenser : DispenseChain 
    {
        private DispenseChain _nextChain;


        public Bill100Dispenser ()
        {
        } 


        public void Dispense(Currency cur)
        {
            
                if (cur.GetAmount() >= 100)
                {
                    int num = cur.GetAmount() / 100;
                    int remainder = cur.GetAmount() % 100;
                    Console.WriteLine("Dispensing " + num + " " + 100 + "DKK note");
                    if (remainder != 0) this._nextChain.Dispense(new Currency(remainder));
                }
                else
                {
                    _nextChain.Dispense(cur);
                }
            
            
        }

        public void SetNextChain(DispenseChain nextChain)
        {
            _nextChain = nextChain;
        }
    }
}

