using System;
namespace GoFState
{
    public class Flashlight
    {
        FlashlightState onState;
        FlashlightState offState;

     FlashlightState _state;

        public Flashlight()
        {

            _state = new Off();
            onState = new On();
            offState = new Off();
        }

        public void Power()
        {
            _state.HandlePower(this);
        }

        public void LightOn()
        {
            Console.WriteLine("Light is on");
        }


        public void LightOff()
        {
            Console.WriteLine("Light is off");
        }

        public void SetState(FlashlightState state)
        {
            _state = state;

        }
    }
}

