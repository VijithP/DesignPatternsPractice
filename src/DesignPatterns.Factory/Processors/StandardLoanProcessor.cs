using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Processors;

public class StandardLoanProcessor : ILoanProcessor
{
    public decimal CalculateInterest(decimal loanAmount)
    {
        return loanAmount * 0.02m;
    }

    public string GetLoanType()
    {
        return "Standard Loan";
    }
}