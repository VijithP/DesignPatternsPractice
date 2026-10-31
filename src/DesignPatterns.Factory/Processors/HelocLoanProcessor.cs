using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Processors;

public class HelocLoanProcessor : ILoanProcessor
{
    public decimal CalculateInterest(decimal loanAmount)
    {
        return loanAmount * 0.03m;
    }

    public string GetLoanType()
    {
        return "HELOC Loan";
    }
}