using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Cards
{
    public class YellowCard : Card
    {

        public YellowCard(int number) : base()
        {
            Number = number;
            Suit = 4;
            SuitType = "Yellow";
        }
    }
}
