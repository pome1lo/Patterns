public abstract class Prototype
{
    public string Name { get; }

    protected Prototype(string name) => this.Name = name;

    public abstract Prototype Clone();
}

public class ConcretePrototype_1 : Prototype
{
    public ConcretePrototype_1(string name) : base(name) { }

    public override Prototype Clone() => new ConcretePrototype_1(Name);
}

public class ConcretePrototype_2 : Prototype
{
    public ConcretePrototype_2(string name) : base(name) { }

    public override Prototype Clone() => new ConcretePrototype_2(Name);
}

internal class Program
{
    // Паттерн Прототип (Prototype) позволяет создавать объекты на основе уже
    // ранее созданных объектов-прототипов. То есть по сути данный паттерн
    // предлагает технику клонирования объектов.
    private static void Main(string[] args)
    {
        Prototype prot_1 = new ConcretePrototype_1("name_1");

        var clone = prot_1.Clone();

        Console.WriteLine(prot_1.Name);
        Console.WriteLine(clone.Name);

        prot_1 = new ConcretePrototype_2("name_2");
        clone = prot_1.Clone();

        Console.WriteLine(prot_1.Name);
        Console.WriteLine(clone.Name);
    }
}