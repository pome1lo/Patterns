abstract class Builder
{
    public abstract void BuilderPartA();
    public abstract void BuilderPartB();
    public abstract void BuilderPartC();
    public abstract Product GetResult();
}

internal class Product
{
    public List<string> list = new();

    public void Add(string part) => list.Add(part);
}

internal class Director
{
    private Builder Builder;

    public Director(Builder builder) => this.Builder = builder;

    public void Construct()
    {
        Builder.BuilderPartA();
        Builder.BuilderPartB();
        Builder.BuilderPartC();
    }
}

internal class ConcreteBuilder : Builder
{
    private Product Product = new();

    public override void BuilderPartA() => Product.Add("part_1");
    public override void BuilderPartB() => Product.Add("part_2");
    public override void BuilderPartC() => Product.Add("part_3");

    public override Product GetResult() => Product;
}

internal class Program
{
    // Строитель (Builder) - шаблон проектирования, который инкапсулирует
    // создание объекта и позволяет разделить его на различные этапы.
    private static void Main(string[] args)
    {
        var builder = new ConcreteBuilder();
        var director = new Director(builder);

        director.Construct();

        builder.GetResult().list.ForEach(x => Console.WriteLine(x));
    }
}