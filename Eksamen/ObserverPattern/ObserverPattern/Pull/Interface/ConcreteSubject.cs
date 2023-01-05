using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Pull.Interface
{
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private SubjectData _data = new SubjectData();
        public void Attach(IObserver observer) 
        {
            observers.Add(observer);
        }
        public void Detach(IObserver observer) 
        {
            observers.Remove(observer);
        }
        public void Notify() 
        {
            foreach (IObserver observer in observers) {
                observer.Update();
            }
        }

        public void ChangeSubjectValue(SubjectData data) {
            _data = data;
            Notify();
        }

        SubjectData ISubject.GetState() {
            return _data;
        }
    }
}
