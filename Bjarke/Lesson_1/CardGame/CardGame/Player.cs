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
        protected readonly List<Card> _playerHand = new List<Card>();
        public string Name { get; protected set; }

        public Player(string name)
        {
            Name = name;
        }


        public string ShowHand()
        {
            // Must return ToString from Card foreach Card in hand
            StringBuilder builder = new StringBuilder();
            builder.Append($"{Name} : (total: {TotalHandValue()} ) ");
            foreach (var card in _playerHand)
            {
                builder.Append(card.ToString() + "; ");
            }

            builder.Append("\r\n");
            return builder.ToString();
            
        }

        public int TotalHandValue()
        {
            //Gets all value from PlayerHand and returns it
            int value = 0;
            foreach (var card in _playerHand)
            {
                value += card.GetValue();
            }
            return value;
        }

        public virtual void AcceptCard(Cards.Card newCard)
        {
            _playerHand.Add(newCard);
        }



    }
}
