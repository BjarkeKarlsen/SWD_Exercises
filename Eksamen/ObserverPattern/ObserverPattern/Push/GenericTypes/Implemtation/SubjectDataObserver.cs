using ObserverPattern.Push.GenericTypes.Interface;

namespace ObserverPattern.Push.GenericTypes.ImplemtationSubjectData
{
    public class SubjectDataObserver : Interface.IObserver<SubjectData>
    {
        private ISubject<SubjectData> _subject;

        public SubjectDataObserver(ISubject<SubjectData> subject)
        {
            _subject = subject;
            subject.Attach(this);
        }

        public void Update(SubjectData data)
        {
            // Handle new value of subject data
            Console.WriteLine($"Received new subject value: {data.Measurement}");
        }
    }
}