using StockPortfolio.DataTypes;
using StockPortfolio.Interface;
using StockPortfolio.Observer;
using StockPortfolio.Subject;
using System;

namespace ObserverPush
{
    class Program
    {
        static void Main()
        {
            ISubject<SubjectData> subject = new SubjectMeasurement();

            IObserverImp<SubjectData> observer = new ObserverMeasurement(subject);

            SubjectData data = new SubjectData();
            data.Measurement = 20;

            subject.SetData(data);
            data.Measurement = 21;
            subject.SetData(data);
        }
    }
}
