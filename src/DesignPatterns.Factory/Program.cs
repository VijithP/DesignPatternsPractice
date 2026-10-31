using DesignPatterns.Factory.Factories;

decimal loanAmount = 100000;

Console.WriteLine("Select Loan Type:");
Console.WriteLine("1. Standard");
Console.WriteLine("2. HELOC");
Console.WriteLine("3. Premium");

string loanType = "HELOC";

// Factory creates the appropriate object.
var processor = LoanProcessorFactory.Create(loanType);

// Client uses the common interface.
decimal interest = processor.CalculateInterest(loanAmount);

Console.WriteLine($"Loan Type: {processor.GetLoanType()}");
Console.WriteLine($"Loan Amount: {loanAmount}");
Console.WriteLine($"Interest Amount: {interest}");