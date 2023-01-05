using ObserverPattern.Push.GenericTypes.Interface;

namespace ObserverPattern.Push.GenericTypes.ImplemtationSubjectData
{
    public class ConcreteObserver : Interface.IObserver<DataType>
    {
        private ISubject<DataType> _subject;

        public ConcreteObserver(ISubject<DataType> subject)
        {
            _subject = subject;
            subject.Attach(this);
        }

        public void Update(DataType data)
        {
            // Handle new value of subject data
            Console.WriteLine($"Received new data type value: {data.Width}, {data.Height}");
        }
    }
}