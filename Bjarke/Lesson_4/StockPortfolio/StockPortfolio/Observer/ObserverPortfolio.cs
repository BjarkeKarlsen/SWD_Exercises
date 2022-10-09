using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockPortfolio.DataTypes;
using StockPortfolio.Interface;

namespace StockPortfolio.Observer
{
    public class ObserverPortfolio : IObserverImp<Stock>
    {
        private ISubject<Stock> _subject;

        public ObserverPortfolio(ISubject<Stock> subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }
        public void Update(Stock subject)
        {
            Console.WriteLine($"Received stocks in portfolio \nName: {subject.Name}, Value: {subject.Value}, Amount: {subject.Amount}");
        }
    }
}
