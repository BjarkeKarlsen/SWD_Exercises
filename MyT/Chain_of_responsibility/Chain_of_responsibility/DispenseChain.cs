using System;
namespace Chain_of_responsibility
{
    public interface DispenseChain
    {
        void SetNextChain(DispenseChain nextChain);
        void Dispense(Currency cur);
    }
}

