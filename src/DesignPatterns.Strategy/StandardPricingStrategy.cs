namespace DesignPatterns.Strategy;

public sealed class StandardPricingStrategy: IPricingStrategy
{
    public decimal Calculate(decimal amount)
        => amount * 0.02m;
}