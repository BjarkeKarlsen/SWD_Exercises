using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Exercise5_2.Flashlight
{
    public abstract class FlashlightState
    {
        //public readonly Flashlight _context = new();

        public virtual void HandlePowerOn(Flashlight context)
        {
        }

        public virtual void HandlePowerOff(Flashlight context)
        {
        }

        public virtual void HandleMode(Flashlight context)
        {
        }

    }
}
