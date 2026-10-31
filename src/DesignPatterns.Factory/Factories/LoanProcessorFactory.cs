using DesignPatterns.Factory.Interfaces;
using DesignPatterns.Factory.Processors;

namespace DesignPatterns.Factory.Factories;

public class LoanProcessorFactory
{
    public static ILoanProcessor Create(string loanType)
    {
        return loanType.ToUpperInvariant() switch
        {
            "STANDARD" => new StandardLoanProcessor(),

            "HELOC" => new HelocLoanProcessor(),

            "PREMIUM" => new PremiumLoanProcessor(),

            _ => throw new ArgumentException(
                $"Invalid loan type: {loanType}")
        };
    }
}