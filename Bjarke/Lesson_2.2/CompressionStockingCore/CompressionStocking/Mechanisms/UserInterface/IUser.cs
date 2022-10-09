using System;
using System.Collections.Generic;
using System.Text;

namespace CompressionStocking.UserInterface
{
    public interface IUser
    {
        void InformCompressionInitiated();
        void InformDecompressionInitiated();
        void InformCompressionComplete();
        void InformDecompressionComplete();
    }
}
