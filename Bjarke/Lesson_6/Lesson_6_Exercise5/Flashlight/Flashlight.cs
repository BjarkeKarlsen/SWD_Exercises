using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Exercise2.Flashlight
{
    public class Flashlight
    {
        private FlashlightState _state;
        public Flashlight()
        {
            _state = new Off(this);
        }

        //public void Power()
        //{

        //    _state.HandlePowerOn(this);
        //}

        public void PowerOn()
        {
            _state.HandlePowerOn(this);
        }

        public void PowerOff()
        {
            _state.HandlePowerOff(this);
        }

        public void Mode()
        {
            _state.HandleMode(this);
        }

        public void LightOn()
        {
            Console.WriteLine("Light is on");
        }

        public void LightOff()
        {
            Console.WriteLine("Light is off");
        }

        public void ModeSolid()
        {
            Console.WriteLine("Light is solid");
        }

        public void ModeFlash()
        {
            Console.WriteLine("Light is flasing");
        }


        public void SetState(FlashlightState state)
        {
            _state = state;
        }
    }
}
