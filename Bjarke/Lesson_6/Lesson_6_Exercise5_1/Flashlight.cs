using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Exercise5_1
{
    public class Flashlight
    {
        public enum FlashLightEvent { POWER, MODE };
        enum FlashLigthState { Off, On };
        enum Mode { Solid, Flashing };

        private Mode _currentMode;
        private FlashLigthState _currentState;

        public Flashlight()
        {
            _currentState = FlashLigthState.Off;
            _currentMode = Mode.Solid;
        }

        public void FlaslightEventHandler(FlashLightEvent evt)
        {
            switch (_currentState)
            {
                case FlashLigthState.Off:
                    PowerOff();
                    break;
                case FlashLigthState.On:
                    PowerOn(evt);
                    break;
                default:
                    break;
            }
        }

        private void PowerOff()
        {
            _currentState = FlashLigthState.On;
            _currentMode = Mode.Solid;
            Console.WriteLine("The flashligth is now on");
        }

        private void PowerOn(FlashLightEvent evt)
        {
            switch (evt)
            {
                case FlashLightEvent.POWER:
                    _currentState = FlashLigthState.Off;
                    Console.WriteLine("The flashligth is now off");
                    break;
                case FlashLightEvent.MODE:
                    FlashlightMode();

                    break;
                default:
                    break;

            }
        }

        private void FlashlightMode()
        {
            switch (_currentMode)
            {
                case Mode.Solid:
                    _currentMode = Mode.Flashing;
                    Console.WriteLine("The flashligth is now solid");
                    break;
                case Mode.Flashing:
                    _currentMode = Mode.Solid;
                    Console.WriteLine("The flashligth is now flashing");

                    break;
                default:
                    break;

            }
        }


    }


}


