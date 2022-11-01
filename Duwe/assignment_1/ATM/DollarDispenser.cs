namespace ATM 
{
    public class DollarDispenser : DispenseChain
    {
        private DispenseChain _nextChain;

        private int _denomination;

        public DollarDispenser(int denomination)
        {
            _denomination = denomination;
        }
        public void SetNextChain(DispenseChain nextChain)
        {
            _nextChain = nextChain;
        }

        public void Dispense(Currency cur)
        {
            if (cur.GetAmount() >= _denomination)
            {
                int num = cur.GetAmount() / _denomination;
                int remainder = cur.GetAmount() % _denomination;
                Console.WriteLine("Dispensing " + num + " 100$ note");
                if (remainder != 0) _nextChain.Dispense(new Currency(remainder));
            }
            else
            {
                _nextChain.Dispense(cur);
            }
        }

    }


}