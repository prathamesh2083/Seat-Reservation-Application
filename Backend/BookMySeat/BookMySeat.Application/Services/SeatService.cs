using BookMySeat.Application.Interfaces;
using BookMySeat.Domain.DTO;
using BookMySeat.Domain.Entities;

namespace BookMySeat.Application.Services;

public class SeatService(ISeatRepository seatRepository) : ISeatService
{
    public async Task<int> AddMultipleAsync(int seatsToAdd)
    {
        if (seatsToAdd < 0)
        {
            throw new ArgumentException("Number of seats to add cannot be negative.");
        }
        int seatCount = await seatRepository.GetSeatCountAsync();
        var seatNumbersToAdd = new List<int>();
        for (int seatNumber = seatCount + 1; seatNumber <= seatCount + seatsToAdd; seatNumber++)
        {
            seatNumbersToAdd.Add(seatNumber);
        }
        return await seatRepository.AddMultipleAsync(seatNumbersToAdd);
    }
    public async Task<int> RemoveMultipleAsync(int seatsToRemove)
    {
        if (seatsToRemove < 0)
        {
            throw new ArgumentException("Number of seats to remove cannot be negative.");
        }
        int seatCount = await seatRepository.GetSeatCountAsync();
        if (seatsToRemove > seatCount)
        {
            throw new ArgumentException("Number of seats to remove cannot be greater than the total number of seats.");
        }
        var seatNumbersToRemove = new List<int>();
        for (int seatNumber = seatCount - seatsToRemove + 1; seatNumber <= seatCount; seatNumber++)
        {
            seatNumbersToRemove.Add(seatNumber);
        }
        return await seatRepository.RemoveMultipleAsync(seatNumbersToRemove);
    }

    public async Task<IEnumerable<SeatStatusDTO>> GetSeatsStatusAsync(DateTime date)
    {
        return await seatRepository.GetSeatsStatusAsync(date);
    }
}
