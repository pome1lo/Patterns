public abstract class AbstractFactory
{
    public abstract AbstractProductA CreateProductA();
    public abstract AbstractProductB CreateProductB();
}

public class ConcreteFactoryB : AbstractFactory
{
    public override AbstractProductA CreateProductA() => new ProductA1();

    public override AbstractProductB CreateProductB() => new ProductB1();
}


public class ConcreteFactoryA : AbstractFactory
{
    public override AbstractProductA CreateProductA() => new ProductA2();

    public override AbstractProductB CreateProductB() => new ProductB2();
}

public abstract class AbstractProductA { }
public abstract class AbstractProductB { }

public class ProductA1 : AbstractProductA { }
public class ProductB1 : AbstractProductB { }

public class ProductA2 : AbstractProductA { }
public class ProductB2 : AbstractProductB { }

internal class Program
{
    // Паттерн "Абстрактная фабрика" (Abstract Factory) предоставляет
    // интерфейс для создания семейств взаимосвязанных объектов с
    // определенными интерфейсами без указания конкретных типов данных объектов.

    private AbstractProductA abstractProductA;
    private AbstractProductB abstractProductB;

    public Program(AbstractFactory factory)
    {
        abstractProductB = factory.CreateProductB();
        abstractProductA = factory.CreateProductA();
    }
    public void Run()
    { }

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}