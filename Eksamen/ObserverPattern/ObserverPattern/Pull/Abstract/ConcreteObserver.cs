using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Pull.Abstract
{
    public class ConcreteObserver : IObserver
    {

        private ConcreteSubject _subject;

        public ConcreteObserver(ConcreteSubject subject) {
            _subject = subject;
            subject.Attach(this);
        }

        public void Update() {
            // Get subject data
            SubjectData data = _subject.GetState();

            // Handle new value of subject data
            Console.WriteLine($"Received new subject value: {data.Measurement}");
        }
    }
}
