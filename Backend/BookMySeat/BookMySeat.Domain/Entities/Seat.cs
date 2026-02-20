namespace BookMySeat.Domain.Entities;

public class Seat
{
    public int Id { get; set; }
    public int SeatNumber { get; set; }

    public Seat(int seatNumber)
    {
        ValidateSeatNumber(seatNumber);
        SeatNumber = seatNumber;
    }

    private void ValidateSeatNumber(int seatNumber)
    {
        if (seatNumber < 0)
        {
            throw new ArgumentException("Invalid Seat Number");
        }
    }
}
