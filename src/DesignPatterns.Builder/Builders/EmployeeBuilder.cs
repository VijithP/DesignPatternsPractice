using DesignPatterns.Builder.Models;

namespace DesignPatterns.Builder.Builders;

public class EmployeeBuilder : IEmployeeBuilder
{
    private string? _name;
    private string? _department;
    private string? _email;
    private string? _phone;
    private decimal _salary;
    private string? _address;
    private bool _isRemote;

    public IEmployeeBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public IEmployeeBuilder SetDepartment(string department)
    {
        _department = department;
        return this;
    }

    public IEmployeeBuilder SetEmail(string email)
    {
        _email = email;
        return this;
    }

    public IEmployeeBuilder SetPhone(string? phone)
    {
        _phone = phone;
        return this;
    }

    public IEmployeeBuilder SetSalary(decimal salary)
    {
        _salary = salary;
        return this;
    }

    public IEmployeeBuilder SetAddress(string? address)
    {
        _address = address;
        return this;
    }

    public IEmployeeBuilder SetRemote(bool isRemote)
    {
        _isRemote = isRemote;
        return this;
    }

    public Employee Build()
    {
        if (string.IsNullOrWhiteSpace(_name))
            throw new ArgumentException("Employee name is required.");

        if (string.IsNullOrWhiteSpace(_department))
            throw new ArgumentException("Department is required.");

        if (string.IsNullOrWhiteSpace(_email))
            throw new ArgumentException("Email is required.");

        if (_salary <= 0)
            throw new ArgumentException("Salary must be greater than zero.");

        return new Employee(
            _name,
            _department,
            _email,
            _phone,
            _salary,
            _address,
            _isRemote);
    }
}