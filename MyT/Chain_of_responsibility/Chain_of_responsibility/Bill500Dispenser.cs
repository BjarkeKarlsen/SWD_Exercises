using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Chain_of_responsibility;

namespace Chain_of_responsibility
{
    public class Bill500Dispenser : DispenseChain 
    {
        private DispenseChain _nextChain;


        public Bill500Dispenser ()
        {
        } 


        public void Dispense(Currency cur)
        {
            
                if (cur.GetAmount() >= 500)
                {
                    int num = cur.GetAmount() / 500;
                    int remainder = cur.GetAmount() % 500;
                    Console.WriteLine("Dispensing " + num + " " + 500 + "DKK note");
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

