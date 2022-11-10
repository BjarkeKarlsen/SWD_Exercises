using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public interface IDispenseChain
    {
        void setNext(IDispenseChain next);
        void Dispense(Currency currency);
    }
}
