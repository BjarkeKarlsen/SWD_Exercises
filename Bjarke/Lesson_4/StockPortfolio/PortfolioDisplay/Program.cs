using StockPortfolio.DataTypes;
using StockPortfolio.Interface;
using StockPortfolio.Observer;
using StockPortfolio.Subject;
using System;
using System.Timers;
using System.Threading;
using System.Xml.Linq;

namespace ObserverPush
{
    public class Program
    {
        private static System.Timers.Timer aTimer;



        static void Main()
        {


            Stock stockGoogle = new Stock("GOOGLE", 20, 94.29);
            Stock stockVestas = new Stock("VESTAS", 3, 570.50);
            ISubject<Stock> subject = new SubjectStocks();

            IObserverImp<Stock> observer = new ObserverPortfolio(subject);

            subject.StockChanged += StockTimer;
            long total = 0;
            long threshold = 800000000;
            while (true)
            {
                total += 1;
                if (total >= threshold)
                {

                    subject.SetData(stockVestas);
                    subject.SetData(stockGoogle);
                    total = 0;
                }
            }
            //subject.SetData(stockGoogle.Update());
            //subject.SetData(stockGoogle.Update());
            //subject.SetData(stockGoogle.Update());
            //subject.SetData(stockGoogle.Update());
            //subject.SetData(stockGoogle.Update());

            // If we give stock a life it self then it must update
            // So it calls setData on the subject it self when it updates
            //stockGoogle.Update(subject);
            //stockGoogle.Update(subject);
            //stockGoogle.Update(subject);
            //SetTimer();
            Console.ReadLine();
        }

        private static void StockTimer(Object source, StockEventArgs e)
        {
            e.Stock.Update();

            e.Subject.Notify();
        }
    }


}
