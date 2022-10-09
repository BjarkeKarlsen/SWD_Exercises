using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using CompressionStocking.BusinessLogic;

namespace CompressionStocking.Devices.Compressing
{
    public interface IPump
    {
        void PumpPositive();
        void Stop();
        void PumpNegative();
    }
}

