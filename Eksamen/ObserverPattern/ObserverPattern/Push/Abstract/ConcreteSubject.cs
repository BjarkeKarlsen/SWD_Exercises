using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObserverPattern.Push.Abstract
{
    public class ConcreteSubject : Subject
    {
        private SubjectData _data = new SubjectData();
        public void ChangeSubjectValue(SubjectData data) {
            _data = data;
            Notify();
        }

        public override void Notify() {
            foreach (IObserver observer in observers) {
                observer.Update(_data);
            }

        }

    }
}
