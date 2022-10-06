using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Exercise5_2.Flashlight
{
    public class Solid : FlashlightState
    {
        public Solid(Flashlight context) {
           context.SetState(this);
        }

        public override void HandlePowerOff(Flashlight context) {
            context.LightOff();
            context.SetState(new Off(context));
        }

        public override void HandleMode(Flashlight context) {
            context.ModeFlashing();
            context.SetState(new Flashing(context));
        }
    }

    public class Flashing : FlashlightState
    {
        public Flashing(Flashlight context) {
            context.SetState(this);
        }

        public override void HandlePowerOff(Flashlight context) {
            context.LightOff();
            context.SetState(new Off(context));
        }

        public override void HandleMode(Flashlight context) {
            context.ModeSolid();
            context.SetState(new Solid(context));
        }

       
    }

}
