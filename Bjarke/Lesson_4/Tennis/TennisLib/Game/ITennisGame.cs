using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisLib.TennisGame
{
    public interface ITennisGame
    {
        void WonPoint(string playerName);
        string GetScore();

        void SetState();
    }
}
