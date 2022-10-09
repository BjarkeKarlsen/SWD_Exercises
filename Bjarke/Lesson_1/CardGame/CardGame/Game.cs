using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.GameType;

namespace CardGame
{
    public class Game
    {
        private List<Player> _players = new List<Player>();
        private bool _gameIsStarted = false;
        private readonly Deck _deck;
        private int NUMBER_OF_CARDS_TO_DEAL = 5;
        private readonly IGameType _gameType;

        public Game(Deck deck, IGameType gametype)
        {
            _deck = deck;
            _gameType = gametype;
        }

        public void AcceptPlayers(Player newPlayer)
        {
            if (!_gameIsStarted)
            {
                _players.Add(newPlayer);
            }
            else
            {

            }
        }

        public void Start()
        {
            _gameIsStarted = true;
            DealCards();
        }

        public void DealCards()
        {
            foreach (var player in _players)
            {
                _deck.DealCard(player, NUMBER_OF_CARDS_TO_DEAL);
            }
        }

        public void AnnounceWinner()
        {
            if (!_gameIsStarted)
            {
                System.Console.WriteLine("The game is not started yet. ");
            }
            else
            {
                _gameType.AnnounceWinner(_players);
            }
        }

    }
}
