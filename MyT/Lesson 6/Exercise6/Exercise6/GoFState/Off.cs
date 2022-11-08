using System;
namespace GoFState
{
    public class Off : FlashlightState
    {
        public Off()
        {

        }

        public override void HandlePower(Flashlight flashlight)
        {
            flashlight.LightOn();
            flashlight.SetState();
        }
    }
}

