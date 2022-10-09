namespace CompressionStocking.BusinessLogic
{
    public interface ICompressionEventListener
    {
        void CompressInitiated();
        void CompressCompleted();
        void DecompressInitiated();
        void DecompressCompleted();
    }
}