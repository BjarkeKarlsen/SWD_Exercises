namespace ATM
{

    public class ATMDispenseChain
    {

        private DollarDispenser d1000 = new DollarDispenser(1000);
        private DollarDispenser d100 = new DollarDispenser(100);
        private DollarDispenser d50 = new DollarDispenser(50);
        private DollarDispenser d20 = new DollarDispenser(20);
        private DollarDispenser d10 = new DollarDispenser(10);


        public ATMDispenseChain()
        {
            d1000.SetNextChain(d100);
            d100.SetNextChain(d50);
            d50.SetNextChain(d20);
            d20.SetNextChain(d10);
        }

        public void Dispense(Currency cur)
        {
            d1000.Dispense(cur);
        }

    }

}