using System;
using Chain_of_responsibility;

namespace Chain_of_responsibility
{
    public class ATM
    {
        private IDispenseChain c1;
        private IDispenseChain c2;
        private IDispenseChain c3;
        private IDispenseChain c4;
        private IDispenseChain c5;
    

        public ATM()
        {
            // initialize the chain
            c1 = new DollarDispenser(1000);
            c2 = new DollarDispenser(500);
            c3 = new DollarDispenser(200);
            c4 = new DollarDispenser(100);
            c5 = new DollarDispenser(50);


            // set the chain of responsibility
            c1.SetNextChain(c2);
            c2.SetNextChain(c3);
            c3.SetNextChain(c4);
            c4.SetNextChain(c5);
        }
        public void Dispense(Currency cur)
        {
            c1.Dispense(cur);
        }
    }
}

