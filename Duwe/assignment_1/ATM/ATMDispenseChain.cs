namespace ATM
{

    public class ATMDispenseChain
    {

        private DollarDispenser d100 = new DollarDispenser(100);
        private DollarDispenser d50 = new DollarDispenser(50);
        private DollarDispenser d20 = new DollarDispenser(20);
        private DollarDispenser d10 = new DollarDispenser(10);


        public ATMDispenseChain()
        {
            d100.SetNextChain(d50);
            d50.SetNextChain(d20);
            d20.SetNextChain(d10);
        }
               
    }

}