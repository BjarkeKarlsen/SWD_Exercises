
namespace ATM
{

    public interface DispenseChain
    {
        void SetNextChain(DispenseChain nextChain);
        void Dispense(Currency cur);
    }


}