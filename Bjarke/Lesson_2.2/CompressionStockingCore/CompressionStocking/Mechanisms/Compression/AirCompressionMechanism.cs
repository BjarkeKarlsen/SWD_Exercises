using System;
using System.Collections.Generic;
using System.Text;
using CompressionStocking.Devices.Compressing;
using System.Threading;
using Timer = System.Timers.Timer;
using System.Timers;

namespace CompressionStocking.Mechanisms.Compression
{
    public class AirCompressionMechanism : CompressionMechanism
    {
        private readonly IPump _pump;
        private readonly Timer _compressionTimer;
        private readonly Timer _decompressionTimer;


        public AirCompressionMechanism(IPump pump, uint compressionTime, uint decompressionTime)
        {
            _pump = pump;

            _compressionTimer = new Timer(compressionTime);
            _compressionTimer.Elapsed += CompressionCompleteTimeout;

            _decompressionTimer = new Timer(decompressionTime);
            _decompressionTimer.Elapsed += DecompressionCompleteTimeout;
        }

        private void DecompressionCompleteTimeout(object sender, ElapsedEventArgs e)
        {
            _decompressionTimer.Stop();
            _pump.Stop();
            InformDecompressinComplete();
        }

        private void CompressionCompleteTimeout(object o, ElapsedEventArgs e)
        {
            _compressionTimer.Stop();
            _pump.Stop();
            InformDecompressinComplete();
        }



        public override void Compress()
        {
            InformCompressionInitiated();
            _pump.PumpPositive();
            _compressionTimer.Start();
        }

        public override void Decompress()
        {
            InformDecompressionInitiated();
            _pump.PumpNegative();
            _decompressionTimer.Start();
        }

        public override void Stop()
        {
            _pump.Stop();
            _compressionTimer.Stop();
            _decompressionTimer.Stop();
        }
    }
}
