using System;
using Chain_of_responsibility;

namespace Chain_of_responsibility
{
    public class ATM
    {
        private DispenseChain c1;
        private DispenseChain c2;
        private DispenseChain c3;
        private DispenseChain c4;
        private DispenseChain c5;
    

        public ATM()
        {
            // initialize the chain
            c1 = new Bill1000Dispenser();
            c2 = new Bill500Dispenser();
            c3 = new Bill200Dispenser();
            c4 = new Bill1000Dispenser();
            c5 = new Bill500Dispenser();


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

