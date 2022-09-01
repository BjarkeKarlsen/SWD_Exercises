using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.Cards;

namespace CardGame
{
    public class Deck
    {
        private readonly int AmountOfTypes = 4;
        private readonly Random r = new Random();
        private readonly List<Card> DeckOfCards = new List<Card>();

        public Deck()
        {
            CreateCards();
            Shuffle();

        }

        private void Shuffle()
        {
            int numberOfCards = DeckOfCards.Count;

            //Swaps two random cards a large number of cards 
            for (int i = 0; i < numberOfCards * (8 * AmountOfTypes); i++)
            {
                int index1 = r.Next(0, numberOfCards - 1);
                int index2 = r.Next(0, numberOfCards - 1);

                Card temp = DeckOfCards[index1];
                DeckOfCards[index1] = DeckOfCards[index2];
                DeckOfCards[index2] = temp;

            }
        }

        private void CreateCards()
        {
            for (int i = 0; i <= 8; i++)
            {
                DeckOfCards.Add(new RedCard(i));
                DeckOfCards.Add(new BlueCard(i));
                DeckOfCards.Add(new GreenCard(i));
                DeckOfCards.Add(new YellowCard(i));

            }
        }

        public void DealCard(Player player, int Amount)
        {

            for (int i = 0; i < Amount; i++)
            {

                int CardRandom = r.Next(0, DeckOfCards.Count);
                Card card = DeckOfCards[CardRandom];
                player.AcceptCard(card);
                DeckOfCards.Remove(card);


            }
        }
    }
}
