using System;
using System.Collections.Generic;
using System.Text;
using CompressionStocking.BusinessLogic;

namespace CompressionStocking.Mechanisms.Compression
{
    public abstract class CompressionMechanism : ICompressionMechanism
    {
        public ICompressionEventListener CompressionEventListener { set; private get; }

        public abstract void Compress();
        public abstract void Decompress();
        public abstract void Stop();

        protected CompressionMechanism()
        {
            CompressionEventListener = null;
        }

        protected void InformCompressionInitiated()
        {
            CompressionEventListener?.CompressInitiated();
        }

        protected void InformCompressionCompleted()
        {
            CompressionEventListener?.CompressCompleted();
        }

        protected void InformDecompressionInitiated()
        {
            CompressionEventListener?.DecompressInitiated();
        }

        protected void InformDecompressinComplete()
        {
            CompressionEventListener?.DecompressCompleted();
        }
    }
}
