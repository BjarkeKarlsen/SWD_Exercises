using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisLib.TennisGame;

namespace TennisLib.ScoreSystem.ScoreSystem
{
    public interface IScoreSystem
    {
        public string GetScore(ITennisGame game);
        public int CalculateScore(ITennisGame game);
        public string IsEqualScore(ITennisGame game);
        public string AdvantagePlayer(ITennisGame game);

        public string ScoreAboveFour(ITennisGame game);
    }
}
