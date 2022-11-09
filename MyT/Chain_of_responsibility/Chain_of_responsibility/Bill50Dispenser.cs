using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Chain_of_responsibility;

namespace Chain_of_responsibility
{
    public class Bill50Dispenser : DispenseChain 
    {
        private DispenseChain _nextChain;


        public Bill50Dispenser ()
        {
        } 


        public void Dispense(Currency cur)
        {
            
            
                if (cur.GetAmount() >= 50)
                {
                    int num = cur.GetAmount() / 50;
                    int remainder = cur.GetAmount() % 50;
                    Console.WriteLine("Dispensing " + num + " " + 50 + "DKK note");
                    if (remainder != 0) _nextChain.Dispense(new Currency(remainder));
                }
                else
                {
                    Console.WriteLine("Cannot dispense the amount");
                }
            
            
        }
        public void SetNextChain(DispenseChain nextChain)
        {
            _nextChain = nextChain;
        }
    }
}

