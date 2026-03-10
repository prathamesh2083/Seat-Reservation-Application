using BookMySeat.Domain.Entities;

namespace BookMySeat.Domain.DTO;

public record GetAllBookingsDTO(DateTime BookingDate, int Id, Employee Employee, Seat Seat);
