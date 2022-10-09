using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio.Interface
{
    public interface IObserverImp<T>
    {
        void Update(T subject);
    }
}
