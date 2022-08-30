using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Cards
{
    public class GreenCard : Card
    {
        public GreenCard(int number) : base()
        {
            Number = number;
            Suit = 3;
            SuitType = "Green";
        }
    }
}
