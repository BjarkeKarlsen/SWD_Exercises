using System;
namespace Exercise6
{
    public class SimpleFlashlight
    {
        public enum FlashLightEvent { PowerBtnPressed }
        enum FlashLightState { On, Off }

        private FlashLightState _currentstate;

        public SimpleFlashlight()
        {
            _currentstate = FlashLightState.Off;
       
        }


        public void HandleEvent(FlashLightEvent evt)
        {
            switch(_currentstate)
            {
                case FlashLightState.On:
                    _currentstate = FlashLightState.Off;
                    Console.WriteLine("Light is off!");
                    break;
                case FlashLightState.Off:
                    _currentstate = FlashLightState.On;
                    Console.WriteLine("Light is on!");
                    break;

            }
        }
        

    }

}

