public interface IObserver
{
    void Update();
}

public interface IObservable
{
    void Add(IObserver observer);
    void Remove(IObserver observer);
    void Publish();
}



public class ConcreteObservable : IObservable
{
    private List<IObserver> _observers = new List<IObserver>();
    public void Add(IObserver observer) => _observers.Add(observer);
    public void Remove(IObserver observer) => _observers.Remove(observer);

    public void Publish() => _observers.ForEach(x => x.Update());
}

public class Observer_1 : IObserver
{
    public void Update() => Console.WriteLine("I AM Observer 1");
}

public class Observer_2 : IObserver
{
    public void Update() => Console.WriteLine("I AM Observer 2");
}



internal class Program
{
    // Паттерн "Наблюдатель" (Observer) представляет поведенческий шаблон проектирования,
    // который использует отношение "один ко многим". В этом отношении есть один наблюдаемый
    // объект и множество наблюдателей. И при изменении наблюдаемого объекта автоматически
    // происходит оповещение всех наблюдателей.
    private static void Main(string[] args)
    {
        var obs = new ConcreteObservable();

        var observer_1 = new Observer_1();
        var observer_2 = new Observer_2();

        obs.Add(observer_1);
        obs.Add(observer_2);

        obs.Publish();
    }
}