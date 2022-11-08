using System;
namespace Chain_of_responsibility
{
    public interface IDispenseChain
    {
        void SetNextChain(IDispenseChain nextChain);
        void Dispense(Currency cur);
    }
}

