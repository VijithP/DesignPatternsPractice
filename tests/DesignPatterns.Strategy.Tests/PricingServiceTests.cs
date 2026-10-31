using DesignPatterns.Strategy;

namespace DesignPatterns.Strategy.Tests;

public class PricingServiceTests
{
    [Fact]
    public void Calculate_StandardPricing_ReturnsExpectedAmount()
    {
        var strategy = new StandardPricingStrategy();
        var service = new PricingService(strategy);

        var result = service.Calculate(1000m);

        Assert.Equal(20m, result);
    }

    [Fact]
    public void Calculate_HelocPricing_ReturnsExpectedAmount()
    {
        var strategy = new HelocPricingStrategy();
        var service = new PricingService(strategy);

        var result = service.Calculate(1000m);

        Assert.Equal(30m, result);
    }
}