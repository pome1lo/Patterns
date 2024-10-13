
public interface ITransport
{
    void Drive();
}

public interface IAnimal
{
    void Move();
}

public class Car : ITransport
{
    public void Drive() => Console.WriteLine("Я машина я еду");
}

public class Camel : IAnimal
{
    public void Move() => Console.WriteLine("Я верблюд я иду");
}



public class Driver()
{
    public void Travel(ITransport transport) => transport.Drive();
}

public class CustomAdapter() : ITransport
{
    private IAnimal _animal;

    public CustomAdapter(IAnimal animal) : this()
    {
        this._animal = animal;
    }

    public void Drive()
    {
        _animal.Move();
    }
}

internal class Program
{
    // Паттерн Адаптер (Adapter) предназначен для преобразования
    // интерфейса одного класса в интерфейс другого. Благодаря
    // реализации данного паттерна мы можем использовать
    // вместе классы с несовместимыми интерфейсами.
    private static void Main(string[] args)
    {
        var driver = new Driver();
        var car = new Car();
        var camel = new Camel();

        driver.Travel(car);

        var adapter = new CustomAdapter(camel);

        driver.Travel(adapter);
    }
}