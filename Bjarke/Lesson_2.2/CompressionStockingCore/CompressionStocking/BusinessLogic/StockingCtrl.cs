using CompressionStocking.Devices.Compressing;
using CompressionStocking.Mechanisms.Compression;
using CompressionStocking.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking.BusinessLogic
{
    public class StockingCtrl : IBtnHandler, ICompressionEventListener
    {
        private enum State
        {
            Relaxed,
            Compressing,
            Compressed,
            Decompressing
        };


        private State _state;
        private readonly ICompressionMechanism _compressionMechanism;
        private readonly IUser _userOutput;
        public StockingCtrl(ICompressionMechanism compressionMechanism, IUser userOuput)
        {
            _userOutput = userOuput;
            _compressionMechanism = compressionMechanism;
            _state = State.Relaxed;
        }


        // From IBtnHandler
        public void StartBtnPushed()
        {
            switch (_state)
            {
                case State.Relaxed:
                    _state = State.Compressing;
                    _compressionMechanism.Compress();
                    break;

                case State.Decompressing:
                    _state = State.Decompressing;
                    _compressionMechanism.Stop();
                    _compressionMechanism.Compress();
                    break;

            }

        }

        public void StopBtnPushed()
        {
            switch (_state)
            {
                case State.Compressed:
                    _state = State.Compressing;
                    _compressionMechanism.Decompress();
                    break;

                case State.Compressing:
                    _state = State.Compressing;
                    _compressionMechanism.Stop();
                    _compressionMechanism.Decompress();
                    break;
            }
        }



        public void CompressInitiated()
        {
            _userOutput.InformCompressionInitiated();
        }

        public void CompressCompleted()
        {
            _state = State.Compressed;
            _userOutput.InformCompressionComplete();
        }

        public void DecompressInitiated()
        {

            _userOutput.InformDecompressionInitiated();
        }

        public void DecompressCompleted()
        {
            _state = State.Relaxed;
            _userOutput.InformDecompressionComplete();
        }
    }
}
