using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Chain_of_responsibility;

namespace Chain_of_responsibility
{
    public class Bill1000Dispenser : DispenseChain 
    {
        private DispenseChain _nextChain;


        public Bill1000Dispenser ()
        {
        } 


        public void Dispense(Currency cur)
        {
            
                if (cur.GetAmount() >= 1000)
                {
                    int num = cur.GetAmount() / 1000;
                    int remainder = cur.GetAmount() % 1000;
                    Console.WriteLine("Dispensing " + num + " " + 1000 + "DKK note");
                    if (remainder != 0) this._nextChain.Dispense(new Currency(remainder));
                }
                else
                {
                    this._nextChain.Dispense(cur);
                }
            
            
        }

        public void SetNextChain(DispenseChain nextChain)
        {
            this._nextChain = nextChain;
        }
    }
}

