using BookMySeat.Domain.DTO;
using BookMySeat.Domain.Enums;

namespace BookMySeat.Domain.Entities;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }

    public Employee(AddEmployeeDTO employee)
    {
        ValidateEmployee(employee);
        Name = employee.Name;
        Email = employee.Email;
        Role = employee.Role;
        Password = employee.Password;
    }

    private void ValidateEmployee(AddEmployeeDTO employee)
    {
        ValidateName(employee.Name);
        ValidateEmail(employee.Email);
        ValidateRole(employee.Role);
        ValidatePassword(employee.Password);
    }

    private void ValidateName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException("Employee Name cannot be empty");
        }

    }

    private void ValidateEmail(string email)
    {
        if (string.IsNullOrEmpty(email) || !email.Contains('@'))
        {
            throw new ArgumentException("Invalid Email");
        }

    }

    private void ValidateRole(Role role)
    {
        if (!Enum.IsDefined(typeof(Role), role))
        {
            throw new ArgumentException("Invalid Role");
        }
    }

    private void ValidatePassword(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            throw new ArgumentNullException("Password cannot be empty");
        }
    }
}
