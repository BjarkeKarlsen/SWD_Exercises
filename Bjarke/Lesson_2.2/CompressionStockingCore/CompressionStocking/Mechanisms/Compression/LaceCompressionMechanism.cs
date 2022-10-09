using CompressionStocking.Devices.UserInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using CompressionStocking.Devices.Compressing;

namespace CompressionStocking.Mechanisms.Compression
{
    public class LaceCompressionMechanism : CompressionMechanism
    {
        private readonly uint _nClickToCompress;
        private readonly uint _msBetweenClicks;
        private readonly ILaceTighteningDevice _laceTighteningDevice;

        public LaceCompressionMechanism(uint nClickToCompress, uint msBetweenClicks, ILaceTighteningDevice laceTighteningDevice)
        {
            _nClickToCompress = nClickToCompress;
            _msBetweenClicks = msBetweenClicks;
            _laceTighteningDevice = laceTighteningDevice;
        }
        public override void Compress()
        {
            InformCompressionInitiated();
            for (uint i = 0; i < _nClickToCompress; i++)
            {
                _laceTighteningDevice.Tighten();
                Thread.Sleep((int)_msBetweenClicks);
            }
            InformDecompressinComplete();
        }

        public override void Decompress()
        {
            InformDecompressionInitiated();
            {
                _laceTighteningDevice.Tighten();
                Thread.Sleep((int)_msBetweenClicks);
            }
            InformDecompressinComplete();
        }

        public override void Stop()
        {

        }
    }
}
