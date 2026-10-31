namespace DesignPatterns.Builder.Models;

public class Employee
{
    public string Name { get; }
    public string Department { get; }
    public string Email { get; }
    public string? Phone { get; }
    public decimal Salary { get; }
    public string? Address { get; }
    public bool IsRemote { get; }

    internal Employee(
        string name,
        string department,
        string email,
        string? phone,
        decimal salary,
        string? address,
        bool isRemote)
    {
        Name = name;
        Department = department;
        Email = email;
        Phone = phone;
        Salary = salary;
        Address = address;
        IsRemote = isRemote;
    }
}