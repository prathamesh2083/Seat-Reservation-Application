using BookMySeat.Domain.Entities;

namespace BookMySeat.Application.Interfaces;

public interface ISeatRepository
{
    public Task<List<Seat>> GetAllSeatsAsync();
}
