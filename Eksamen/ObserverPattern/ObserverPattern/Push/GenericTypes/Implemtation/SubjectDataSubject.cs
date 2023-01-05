using ObserverPattern.Push.GenericTypes.Interface;

namespace ObserverPattern.Push.GenericTypes.ImplemtationSubjectData
{
    public class DataTypeSubject : ISubject<SubjectData>
    {
        private List<Interface.IObserver<SubjectData>> _observers = new List<Interface.IObserver<SubjectData>>();
        private SubjectData _data = new SubjectData();
        public void Attach(Interface.IObserver<SubjectData> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }
        public void Detach(Interface.IObserver<SubjectData> observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_data);
            }
        }

        public void ChangeSubjectValue(SubjectData data)
        {
            _data = data;
            Notify();
        }
    }
}
