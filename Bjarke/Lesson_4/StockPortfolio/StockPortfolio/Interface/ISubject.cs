using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using StockPortfolio.DataTypes;
using StockPortfolio.Subject;

namespace StockPortfolio.Interface
{
    public interface ISubject<T>
    {
        void Attach(IObserverImp<T> obs);
        void Detach(IObserverImp<T> obs);
        void Notify();
        void SetData(T data);

        public event EventHandler<StockEventArgs> StockChanged;
    }
}
