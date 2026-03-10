using BookMySeat.Domain.Enums;

namespace BookMySeat.Domain.DTO;

public record  EmployeeInfoDTO(int EmployeeId,string EmployeeName,Role role,string Email);
