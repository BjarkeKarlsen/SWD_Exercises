using System;
using System.Collections.Generic;
using System.Text;
using CompressionStocking.Devices.UserInterface;

namespace CompressionStocking.UserInterface
{
    public class User : IUser
    {

        private readonly ITwoStateUnit _greenLED;
        private readonly ITwoStateUnit _redLED;
        private readonly ITwoStateUnit _vibrator;
        public User(ITwoStateUnit greenLED, ITwoStateUnit redLED, ITwoStateUnit vibrator)
        {
            _greenLED = greenLED;
            _redLED = redLED;
            _vibrator = vibrator;

            _greenLED.TurnOff();
            _redLED.TurnOff();
            _vibrator.TurnOff();

        }
        public void InformCompressionComplete()
        {
            _greenLED.TurnOff();
            _vibrator.TurnOff();
        }

        public void InformCompressionInitiated()
        {
            _greenLED.TurnOn();
            _vibrator.TurnOn();
        }

        public void InformDecompressionComplete()
        {
            _redLED.TurnOn();
            _vibrator.TurnOn();
        }

        public void InformDecompressionInitiated()
        {
            _redLED.TurnOff();
            _vibrator.TurnOff();
        }
    }
}

