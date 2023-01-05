namespace ObserverPattern.Pull.Interface
{
    public class ConcreteObserver : IObserver
    {
        private ISubject _subject;

        public ConcreteObserver(ISubject subject) {
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