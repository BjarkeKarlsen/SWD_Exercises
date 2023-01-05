
namespace ObserverPattern.Push.GenericTypes.Interface
{
    public interface IObserver<T>
    {
        public void Update(T subjectData);
    }
}
