using BookMySeat.Application.Interfaces;
using BookMySeat.Domain.DTO;
using BookMySeat.Domain.Entities;
using BookMySeat.Infrastructure.Database;
using BookMySeat.Infrastructure.Database.SqlQueries;

namespace BookMySeat.Infrastructure.Repositories;

public class SeatRepository(DapperDbContext dapperDbContext) : ISeatRepository
{
    public async Task<int> AddAsync(int seatNumber)
    {
        return await dapperDbContext.ExecuteAsync(SeatSQLQueries.AddSeatQuery(seatNumber));
    }
    public async Task<int> AddMultipleAsync(List<int> seatNumbers)
    {
        return await dapperDbContext.ExecuteAsync(SeatSQLQueries.AddMultipleSeatsQuery(seatNumbers));
    }
    public async Task<int> RemoveAsync(int seatNumber)
    {
        return await dapperDbContext.ExecuteAsync(SeatSQLQueries.RemoveSeatQuery(seatNumber));
    }
    public async Task<int> RemoveMultipleAsync(List<int> seatNumbers)
    {
        return await dapperDbContext.ExecuteAsync(SeatSQLQueries.RemoveMultipleSeatsQuery(seatNumbers));
    }
    public async Task<IEnumerable<SeatStatusDTO>> GetSeatsStatusAsync(DateTime date)
    {
        return await dapperDbContext.QueryAsync<SeatStatusDTO>(SeatSQLQueries.GetSeatsStatusQuery(date));
    }
    public async Task<int> GetSeatCountAsync()
    {
        string query = "SELECT COUNT(*) FROM Seat";
        return await dapperDbContext.QuerySingleOrDefaultAsync<int>(query);
    }
}
