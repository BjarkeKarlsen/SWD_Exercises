using TennisLib.TennisGame;

namespace TennisLib.Players
{
    public class Player : ITennisGame
    {
        public string Name { get; private set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

    }
}