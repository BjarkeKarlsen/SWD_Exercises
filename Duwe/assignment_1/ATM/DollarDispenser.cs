namespace ATM 
{
    public class DollarDispenser : DispenseChain
    {
        private DispenseChain _nextChain = null;

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
            if (cur.GetAmount() % 10 != 0 )
            {
                Console.WriteLine("Amount must be divisible by 10");
                return;
            }

            if (cur.GetAmount() >= _denomination)
            {
                int num = cur.GetAmount() / _denomination;
                int remainder = cur.GetAmount() % _denomination;
                Console.WriteLine("Dispensing " + num + " " + _denomination +"$ note");
                if (remainder != 0) _nextChain.Dispense(new Currency(remainder));
            }
            else
            {
                _nextChain.Dispense(cur);
            }
        }

    }


}