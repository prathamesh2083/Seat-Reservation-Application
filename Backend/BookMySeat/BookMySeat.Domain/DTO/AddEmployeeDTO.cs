using BookMySeat.Domain.Enums;

namespace BookMySeat.Domain.DTO;

public class AddEmployeeDTO
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }
}
