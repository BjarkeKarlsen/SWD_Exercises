using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using StockPortfolio.Observer;
using System.Xml.Linq;
using StockPortfolio.Interface;
using StockPortfolio.DataTypes;
using StockPortfolio.Subject;

namespace StockPortfolio.Subject
{
    public class SubjectStocks : ISubject<Stock>
    {
        private List<IObserverImp<Stock>> _observers;
        private Stock _stock;

        public SubjectStocks()
        {
            _observers = new();
            _stock = new();
        }

        public void Attach(IObserverImp<Stock> obs)
        {
            if (!_observers.Contains(obs))
            {
                _observers.Add(obs);
            }

        }
        public void Detach(IObserverImp<Stock> obs)
        {
            if (!_observers.Contains(obs))
            {
                _observers.Remove(obs);
            }
        }
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_stock);

            }
        }

        public void SetData(Stock newStock)
        {
            _stock = newStock.Update();
            Notify();
        }



        //public void Add(long x)
        //{
        //    total += x;
        //    if (total <= threshold)
        //    {
        //        StockEventArgs args = new StockEventArgs();
        //        //Update();
        //        //args.Óbser = _observers;
        //        args.Stock.Name = _stock.Name;
        //        args.Stock.Amount = _stock.Amount;
        //        args.Stock.Value = _stock.Value;
        //        //args.Observer = _observers;

        //        args.Subject = this;
        //        OnThresholdReached(args);
        //    }
        //}

        //protected virtual void OnThresholdReached(StockEventArgs e)
        //{
        //    EventHandler<StockEventArgs> handler = StockChanged;
        //    if (handler != null)
        //    {
        //        handler(this, e);
        //    }
        //}

        public event EventHandler<StockEventArgs> StockChanged;

    }
    public class StockEventArgs : EventArgs
    {
        public Stock? Stock { get; set; }
        public ISubject<Stock>? Subject { get; set; }

        public IObserverImp<Stock>? Observer { get; set; }

    }
}
