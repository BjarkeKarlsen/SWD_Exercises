using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Push.Abstract
{
    public abstract class Subject
    {

        protected List<IObserver> observers = new List<IObserver>();
        public void Attach(IObserver observer) {
            observers.Add(observer);
        }
        public void Detach(IObserver observer) {
            observers.Remove(observer);
        }
        public virtual void Notify() {
            foreach (IObserver observer in observers) {
                observer.Update(new SubjectData());
            }
        }


    }
}
