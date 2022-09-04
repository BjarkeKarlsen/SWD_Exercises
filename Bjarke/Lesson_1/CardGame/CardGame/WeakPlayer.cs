using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.Cards;

namespace CardGame
{
    public class WeakPlayer : Player
    {
         
        public WeakPlayer(string name) : base(name)
        {
            
        }

        public override void AcceptCard(Card card)
        {
            if (_playerHand.Count == 3)
            {
                Card toRemove = _playerHand[0];
                _playerHand.Remove(toRemove);
            }

            _playerHand.Add(card);
        }
    }
}
