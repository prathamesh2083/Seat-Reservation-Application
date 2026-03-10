using BookMySeat.Domain.DTO;

namespace BookMySeat.Application.Interfaces;

public interface ISeatRepository
{
    Task<int> AddAsync(int seatNumber);
    Task<int> AddMultipleAsync(List<int> seatNumbers);
    Task<int> RemoveAsync(int seatNumber);
    Task<int> RemoveMultipleAsync(List<int> seatNumbers);
    Task<IEnumerable<SeatStatusDTO>> GetSeatsStatusAsync(DateTime date);
    Task<int> GetSeatCountAsync();
    //Task<Seat> GetBySeatNumberAsync(int seatNumber);
}
