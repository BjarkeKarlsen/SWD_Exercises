using StockPortfolio.DataTypes;
using StockPortfolio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio.Observer
{
    public class ObserverMeasurement : IObserverImp<SubjectData>
    {
        private ISubject<SubjectData> _subject;

        public ObserverMeasurement(ISubject<SubjectData> subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }
        public void Update(SubjectData subject)
        {
            Console.WriteLine($"Received new subject value: {subject.Measurement}");
        }
    }
}
