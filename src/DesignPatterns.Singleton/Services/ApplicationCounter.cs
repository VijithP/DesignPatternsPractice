namespace DesignPatterns.Singleton.Services;

public sealed class ApplicationCounter
{
    private static readonly ApplicationCounter _instance =
        new ApplicationCounter();

    private ApplicationCounter()
    {
    }

    public static ApplicationCounter Instance => _instance;

    public int Count { get; private set; }

    public void Increment()
    {
        Count++;
    }
}