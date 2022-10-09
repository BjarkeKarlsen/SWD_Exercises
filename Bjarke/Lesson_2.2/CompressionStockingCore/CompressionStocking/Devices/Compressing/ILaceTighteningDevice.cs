using System;
using System.Collections.Generic;
using System.Text;
using CompressionStocking.BusinessLogic;

namespace CompressionStocking.Devices.Compressing
{
    public interface ILaceTighteningDevice
    {
        void Tighten();
        void Lossen();
    }
}
