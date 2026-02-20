namespace BookMySeat.Domain.DTO;

public class SeatBookingRequestDTO
{
    public DateTime BookingDate { get; set; }
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public int SeatId { get; set; }
}
