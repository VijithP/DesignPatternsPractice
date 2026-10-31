namespace DesignPatterns.Strategy;
public sealed class HelocPricingStrategy : IPricingStrategy
{
    public decimal Calculate(decimal amount)
        => amount * 0.03m;
}