using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisLib.TennisGame;

namespace TennisLib.ScoreSystem
{
    public abstract class ScoreSystem : IScoreSystem
    {
        //public static ScoreSystem ScoreType(ScoreTypeEnum type)
        //{
        //    switch (type)
        //    {
        //        case ScoreTypeEnum.Love:
        //            return ScoreType1();
        //    }
        //}

        public ScoreSystem()
        {

        }

        public string AdvantagePlayer(ITennisGame game)
        {
            throw new NotImplementedException();
        }

        public int CalculateScore(ITennisGame game)
        {
            game.
        }

        public string GetScore(ITennisGame game)
        {
            return ("Player 1 VS Player 2: \n{game._player1.Score} - {_player2.Score} ");
        }
    }

    public string IsEqualScore(ITennisGame game)
    {
        throw new NotImplementedException();
    }

    public string ScoreAboveFour(ITennisGame game)
    {
        throw new NotImplementedException();
    }
}




public enum ScoreTypeEnum
{
    Love,
    Fifteen,
    Thirty,
    Forty,
    Deuce
}



//public string GetScore()
//{
//    string score = "";
//    var tempScore = 0;
//    if (m_score1 == m_score2)
//    {
//        switch (m_score1)
//        {
//            case 0:
//                score = "Love-All";
//                break;
//            case 1:
//                score = "Fifteen-All";
//                break;
//            case 2:
//                score = "Thirty-All";
//                break;
//            default:
//                score = "Deuce";
//                break;

//        }
//    }
//    else if (m_score1 >= 4 || m_score2 >= 4)
//    {
//        var minusResult = m_score1 - m_score2;
//        if (minusResult == 1) score = "Advantage player1";
//        else if (minusResult == -1) score = "Advantage player2";
//        else if (minusResult >= 2) score = "Win for player1";
//        else score = "Win for player2";
//    }
//    else
//    {
//        for (var i = 1; i < 3; i++)
//        {
//            if (i == 1) tempScore = m_score1;
//            else { score += "-"; tempScore = m_score2; }
//            switch (tempScore)
//            {
//                case 0:
//                    score += "Love";
//                    break;
//                case 1:
//                    score += "Fifteen";
//                    break;
//                case 2:
//                    score += "Thirty";
//                    break;
//                case 3:
//                    score += "Forty";
//                    break;
//            }
//        }
//    }
//    return score;
//}