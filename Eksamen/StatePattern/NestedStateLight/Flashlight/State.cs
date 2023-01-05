using Lesson_6_Exercise5_2.Flashlight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Exercise5_2.Flashlight
{
    public class Off : FlashlightState
    {
        public Off(Flashlight context)
        {
            context.SetState(this);
        }

        public override void HandlePowerOn(Flashlight context)
        {
            context.LightOn();
            context.SetState(new On(context));
        }
    }

    public class On : FlashlightState
    {
        public On(Flashlight context)
        {
            context.SetState(new Solid(context));
        }

        public override void HandlePowerOff(Flashlight context)
        {
            context.LightOff();
            context.SetState(new Off(context));
        }

        public override void HandleMode(Flashlight context)
        {
            context.ModeSolid();
            context.SetState(new Solid(context));

        }

    }
}
