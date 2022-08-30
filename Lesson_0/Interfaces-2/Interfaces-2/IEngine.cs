using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_2
{
    public interface IEngine
    {
        uint MaxThrottle { get; }
        uint GetThrottle();
        void SetThrottle(uint thr);


    }
}
