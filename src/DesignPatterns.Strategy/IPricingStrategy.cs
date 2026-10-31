namespace DesignPatterns.Strategy;
public interface IPricingStrategy
{
    decimal Calculate(decimal amount);
}