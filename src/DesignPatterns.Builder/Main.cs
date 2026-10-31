using DesignPatterns.Builder.Builders;

var employee = new EmployeeBuilder()
    .SetName("John")
    .SetDepartment("IT")
    .SetEmail("john@gmail.com")
    .SetSalary(50000)
    .SetAddress("Kerala")
    .SetRemote(true)
    .Build();

Console.WriteLine($"Name: {employee.Name}");
Console.WriteLine($"Department: {employee.Department}");
Console.WriteLine($"Email: {employee.Email}");
Console.WriteLine($"Salary: {employee.Salary}");
Console.WriteLine($"Remote: {employee.IsRemote}");