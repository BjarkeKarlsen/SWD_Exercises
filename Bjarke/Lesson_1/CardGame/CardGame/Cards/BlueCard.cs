using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Cards
{
    public class BlueCard : Card
    {
        public BlueCard(int number) : base()
        {
            Number = number;
            Suit = 2;
            SuitType = "Blue";
        }

    }
}
