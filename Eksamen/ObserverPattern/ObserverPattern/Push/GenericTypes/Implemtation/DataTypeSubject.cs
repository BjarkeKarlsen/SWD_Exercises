using ObserverPattern.Push.GenericTypes.Interface;

namespace ObserverPattern.Push.GenericTypes.ImplemtationSubjectData
{
    public class Subject : ISubject<DataType>
    {
        private List<Interface.IObserver<DataType>> _observers = new List<Interface.IObserver<DataType>>();
        private DataType _data = new DataType();
        public void Attach(Interface.IObserver<DataType> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }
        public void Detach(Interface.IObserver<DataType> observer)
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

        public void ChangeSubjectValue(DataType data)
        {
            _data = data;
            Notify();
        }
    }
}
