using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Processors;

public class PremiumLoanProcessor : ILoanProcessor
{
    public decimal CalculateInterest(decimal loanAmount)
    {
        return loanAmount * 0.015m;
    }

    public string GetLoanType()
    {
        return "Premium Loan";
    }
}