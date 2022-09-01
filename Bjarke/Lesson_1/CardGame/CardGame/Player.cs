using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.Cards;

namespace CardGame
{
    public class Player
    {
        private List<Card> PlayerHand = new List<Card>();
        public string Name { get; protected set; }

        public Player(string name)
        {
            Name = name;
        }


        public void ShowHand()
        {
            // Must return ToString from Card foreach Card in hand
            foreach (Card card in PlayerHand)
            {
                PlayerHand.ToString();
            }
        }

        public int ShowTotalValue()
        {
            //Gets all value from PlayerHand and returns it
            int value = 0;
            foreach (Card card in PlayerHand)
            {
                value += card.GetValue();
            }
            return value;
        }

        public void AcceptCard(Card newCard)
        {
            PlayerHand.Add(newCard);
        }



    }
}
