using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Exercise2.Flashlight
{
    public class On : FlashlightState
    {
        public On(Flashlight context)
        {
            context.SetState(this);
        }

        public override void HandlePowerOn(Flashlight context)
        {
            context.LightOn();
            context.SetState(new Off(context));
        }
    }
}
