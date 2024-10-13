internal class Singleton
{
    private Singleton() { }

    private static Singleton _instance = null!;

    public static Singleton GetInstance()
    {
        _instance ??= new Singleton();
        return _instance;
    }
}

internal class Program
{

    private static void Main(string[] args)
    {
        var singleton = Singleton.GetInstance();

        Console.WriteLine(singleton.ToString());
    }
}