using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.GameType
{
    public class HighHandWins : IGameType
    {
        public void AnnounceWinner(List<Player> players)
        {
            Player winner = players[0];
            foreach (var player in players)
            {
                if (player.TotalHandValue() < winner.TotalHandValue())
                {
                    winner = player;
                }

                System.Console.WriteLine($"The winner is: {winner.Name}");
            }
            
        }
    }
}
