using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    public class SimpleFlashlight
    {
        public enum Power { OFF, ON };
        private Power _currentstate;

        public SimpleFlashlight()
        {
            _currentstate = Power.OFF;
        }

        public void FlaslightEventHandler(Power evt)
        {
            switch (evt)
            {
                case Power.OFF:
                    _currentstate = Power.OFF;
                    Console.WriteLine("The flashligth is now off");
                    break;
                case Power.ON:
                    _currentstate = Power.ON;
                    Console.WriteLine("The flashligth is now on");
                    break;
                default:
                    break;
            }
        }


    }
}
