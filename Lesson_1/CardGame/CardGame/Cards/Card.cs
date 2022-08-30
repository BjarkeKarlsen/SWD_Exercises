namespace CardGame.Cards
{
    public abstract class Card
    {

        public int GetValue()
        {
            return Suit * Number;
        }

        public override string ToString()
        {
            return SuitType + " " + Number + " (" + GetValue() + ")";
        }

        public int Suit { get; protected set; }
        public string SuitType { get; protected set; }
        public int Number { get; protected set; }
    }
}
