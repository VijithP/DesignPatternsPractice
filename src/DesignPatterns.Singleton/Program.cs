using DesignPatterns.Singleton.Services;

var first = ApplicationCounter.Instance;
var second = ApplicationCounter.Instance;

first.Increment();

Console.WriteLine(
    $"Same instance: {ReferenceEquals(first, second)}");

Console.WriteLine($"First count: {first.Count}");
Console.WriteLine($"Second count: {second.Count}");