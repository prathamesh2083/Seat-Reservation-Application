using BookMySeat.Domain.Entities;

namespace BookMySeat.Application.Interfaces;

public interface ISeatService
{
    public Task<List<Seat>> GetAllSeatsAsync();
}
