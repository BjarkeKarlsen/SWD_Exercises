using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Exercise2.Flashlight
{
    public class Off : FlashlightState
    {
        public Off(Flashlight context)
        {
            context.SetState(this);
        }

        public override void HandlePowerOff(Flashlight context)
        {
            context.LightOff();
            context.SetState(new On(context));
        }
    }
}
