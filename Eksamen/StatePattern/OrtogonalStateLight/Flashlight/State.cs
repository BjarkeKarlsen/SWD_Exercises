using Lesson_6_Exercise5_2.Flashlight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Exercise2.Flashlight
{
    public class State : FlashlightState
    {
        public State(Flashlight context)
        {
            context.SetState(this);
        }

        public override void HandlePowerOff(Flashlight context)
        {
            context.LightOff();
            context.SetState(new On(context));
        }
    }

    public class On : FlashlightState
    {
        private FlashlightState _currentMode;

        public On(Flashlight context) {
            _currentMode = new Solid(this);
            context.SetState(this);
        }

        public override void HandlePowerOn(Flashlight context) {
            context.LightOn();
            context.ModeSolid();
            context.SetState(new State(context));
        }

        public override void HandleMode(Flashlight context) {

            context.ModeSolid();

        }

        public override void HandleMode() {

        }
    }
}
