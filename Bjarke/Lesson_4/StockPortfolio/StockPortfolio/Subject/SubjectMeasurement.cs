using StockPortfolio.DataTypes;
using StockPortfolio.Interface;
using StockPortfolio.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio.Subject
{
    public class SubjectMeasurement : ISubject<SubjectData>
    {
        private List<IObserverImp<SubjectData>> _observers;
        private SubjectData _subjectData;

        public SubjectMeasurement()
        {
            _observers = new();
            _subjectData = new();
        }

        public void Attach(IObserverImp<SubjectData> obs)
        {
            if (!_observers.Contains(obs))
            {
                _observers.Add(obs);
            }

        }
        public void Detach(IObserverImp<SubjectData> obs)
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
                observer.Update(_subjectData);

            }
        }

        public void SetData(SubjectData newMeasurement)
        {
            _subjectData = newMeasurement;
            Notify();
        }
        public event EventHandler<StockEventArgs> StockChanged;
    }
}
