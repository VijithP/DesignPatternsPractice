namespace DesignPatterns.Strategy;

public sealed class PricingService
{
    private readonly IPricingStrategy _strategy;

    public PricingService(IPricingStrategy strategy)
    {
        _strategy = strategy;
    }

    public decimal Calculate(decimal amount)
    {
        return _strategy.Calculate(amount);
    }
}