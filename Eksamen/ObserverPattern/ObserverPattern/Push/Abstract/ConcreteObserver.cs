using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Push.Abstract
{
    public class ConcreteObserver : IObserver
    {

        public ConcreteObserver(ConcreteSubject subject) {
            subject.Attach(this);
        }

        public void Update(SubjectData data) {

            // Handle new value of subject data
            Console.WriteLine($"Received new subject value: {data.Measurement}");
        }
    }
}
