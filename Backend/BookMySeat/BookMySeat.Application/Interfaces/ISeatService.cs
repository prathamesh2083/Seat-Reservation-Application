using BookMySeat.Domain.DTO;
using BookMySeat.Domain.Entities;

namespace BookMySeat.Application.Interfaces;

public interface ISeatService
{
    Task<int> AddMultipleAsync(int seatsToAdd);
    Task<int> RemoveMultipleAsync(int seatsToRemove);
    Task<IEnumerable<SeatStatusDTO>> GetSeatsStatusAsync(DateTime date);
}
