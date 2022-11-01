namespace ATM
{
    public class Currency
    {
        private int _amount; 
        public Currency(int amount)
        {
            amount = amount;
        }

        public int GetAmount()
        {
            return _amount;
        }
    }
}