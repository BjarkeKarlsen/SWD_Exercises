using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Pull.Abstract
{
    public class Subject
    {

        private List<IObserver> observers = new List<IObserver>();
        public void Attach(IObserver observer) {
            observers.Add(observer);
        }
        public void Detach(IObserver observer) {
            observers.Remove(observer);
        }
        public void Notify() {
            foreach (IObserver observer in observers) {
                observer.Update();
            }
        }


    }
}
