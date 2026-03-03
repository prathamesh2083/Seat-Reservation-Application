using BookMySeat.Application.Interfaces;
using BookMySeat.Domain.Entities;

namespace BookMySeat.Application.Services;

public class SeatService(ISeatRepository seatRepository) : ISeatService
{
    public async Task<List<Seat>> GetAllSeatsAsync()
    {
        return await seatRepository.GetAllSeatsAsync();
    }
}
