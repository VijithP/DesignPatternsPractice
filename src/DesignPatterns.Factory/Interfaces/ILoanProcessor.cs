namespace DesignPatterns.Factory.Interfaces;

public interface ILoanProcessor
{
    decimal CalculateInterest(decimal loanAmount);

    string GetLoanType();
}