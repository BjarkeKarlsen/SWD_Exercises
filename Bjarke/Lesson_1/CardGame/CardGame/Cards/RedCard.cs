using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Cards
{
    public class RedCard : Card
    {
        public RedCard(int number) : base()
        {
            Number = number;
            Suit = 1;
            SuitType = "Red";
        }


    }
}
