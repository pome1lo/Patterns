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
    // Одиночка (Singleton, Синглтон) - порождающий паттерн, который
    // гарантирует, что для определенного класса будет создан только
    // один объект, а также предоставит к этому объекту точку доступа.
    private static void Main(string[] args)
    {
        var singleton = Singleton.GetInstance();

        Console.WriteLine(singleton.ToString());
    }
}