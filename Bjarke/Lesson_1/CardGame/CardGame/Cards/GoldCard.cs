using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Cards
{
    public class GoldCard : Card
    {
        public GoldCard(int number)
            : base()
        {
            Number = number;
            Suit = 5;
            SuitType = "Gold";
        }
    }
}
