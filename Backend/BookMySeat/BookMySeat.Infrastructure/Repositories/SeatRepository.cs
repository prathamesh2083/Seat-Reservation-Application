using BookMySeat.Application.Interfaces;
using BookMySeat.Domain.Entities;
using BookMySeat.Infrastructure.Database;

namespace BookMySeat.Infrastructure.Repositories;

public class SeatRepository(DapperDbContext dapperDbContext) : ISeatRepository
{
    public async Task<List<Seat>> GetAllSeatsAsync()
    {
        var query = "use BookMySeatDB;select * from seat";
        List<Seat> seats = (await dapperDbContext.QueryAsync<Seat>(query)).ToList();
        return seats;
    }
}
