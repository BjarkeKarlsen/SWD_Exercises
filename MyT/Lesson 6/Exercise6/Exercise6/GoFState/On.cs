using System;
namespace GoFState
{
    public class On : FlashlightState
    {
        public On()
        {

        }

        public override void HandlePower(Flashlight flashlight)
        {
            flashlight.LightOff();
            flashlight.SetState(OffState);
        }
    }
}

