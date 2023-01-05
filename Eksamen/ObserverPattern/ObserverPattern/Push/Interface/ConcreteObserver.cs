namespace ObserverPattern.Push.Interface
{
    public class ConcreteObserver : IObserver
    {
        private ISubject _subject;

        public ConcreteObserver(ISubject subject) {
            _subject = subject;
            subject.Attach();
        }

        public void Update(SubjectData data) {
            // Handle new value of subject data
            Console.WriteLine($"Received new subject value: {data.Measurement}");
        }
    }
}