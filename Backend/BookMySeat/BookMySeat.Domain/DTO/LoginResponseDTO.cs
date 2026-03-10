using BookMySeat.Domain.Entities;

namespace BookMySeat.Domain.DTO;

public record LoginResponseDTO(Boolean Success, string Message, Employee? LoggedInEmployee = null);
