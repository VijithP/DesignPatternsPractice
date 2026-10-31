using DesignPatterns.Builder.Models;

namespace DesignPatterns.Builder.Builders;

public interface IEmployeeBuilder
{
    IEmployeeBuilder SetName(string name);

    IEmployeeBuilder SetDepartment(string department);

    IEmployeeBuilder SetEmail(string email);

    IEmployeeBuilder SetPhone(string? phone);

    IEmployeeBuilder SetSalary(decimal salary);

    IEmployeeBuilder SetAddress(string? address);

    IEmployeeBuilder SetRemote(bool isRemote);

    Employee Build();
}