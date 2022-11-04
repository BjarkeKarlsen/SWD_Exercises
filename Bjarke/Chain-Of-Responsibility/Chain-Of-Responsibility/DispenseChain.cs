using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public interface DispenseChain
    {
        void setNext(DispenseChain next);
        void Dispense(Currency currency);
    }
}
