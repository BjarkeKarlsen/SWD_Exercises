using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisLib.Players;
using TennisLib.ScoreSystem.ScoreSystem;
using TennisLib.TennisGame;

namespace TennisLib.GameTypes
{
    public class TennisGame1 : ITennisGame
    {
        private Player _player1;
        private Player _player2;
        private IScoreSystem _scoreSystem;
        public TennisGame1(string player1, string player2)
        {
            _player1 = new Player(player1);
            _player2 = new Player(player2);
        }

        public string GetScore()
        {
            return _scoreSystem.GetScore(this);
        }


        public void SetState(IScoreSystem scoreSystem)
        {
            _scoreSystem = scoreSystem;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == _player1.Name)
                _player1.Score += 1;
            else
                _player2.Score += 1;
        }

    }
}
