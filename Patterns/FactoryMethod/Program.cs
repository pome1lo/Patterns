
public abstract class Product
{

}

public abstract class Creator
{
    public abstract Product Create();
}



public class ConcreteProduct_1 : Product
{
    public ConcreteProduct_1() => Console.WriteLine(this.ToString());
}

public class ConcreteProduct_2 : Product
{
    public ConcreteProduct_2() => Console.WriteLine(this.ToString());
}

public class ConcreteCreator_1 : Creator
{
    public override Product Create() => new ConcreteProduct_1();
}

public class ConcreteCreator_2 : Creator
{
    public override Product Create() => new ConcreteProduct_2();
}


internal class Program
{
    // Фабричный метод(Factory Method) - это паттерн, который определяет интерфейс
    // для создания объектов некоторого класса, но непосредственное решение о том,
    // объект какого класса создавать происходит в подклассах.То есть паттерн
    // предполагает, что базовый класс делегирует создание объектов классам-наследникам.
    private static void Main(string[] args)
    {
        var prod_1 = new ConcreteCreator_1().Create();

        var prod_2 = new ConcreteCreator_2().Create();
    }
}