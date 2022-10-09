﻿using System;
using System.Collections.Generic;
using System.Text;
using CompressionStocking.BusinessLogic;

namespace CompressionStocking.Mechanisms.Compression
{
    public interface ICompressionMechanism
    {
        ICompressionEventListener CompressionEventListener { set; }
        void Compress();
        void Decompress();
        void Stop();
    }
}
