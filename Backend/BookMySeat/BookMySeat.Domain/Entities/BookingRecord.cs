using BookMySeat.Domain.DTO;

namespace BookMySeat.Domain.Entities;

public class BookingRecord
{
    public DateTime BookingDate { get; set; }
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public int SeatId { get; set; }

    public BookingRecord(SeatBookingRequestDTO booking)
    {
        ValidateBookingRequest(booking);
        BookingDate = booking.BookingDate;
        Id = booking.Id;
        EmployeeId = booking.EmployeeId;
        SeatId = booking.SeatId;
    }
    private void ValidateBookingRequest(SeatBookingRequestDTO booking)
    {
        ValidateBookingDate(booking.BookingDate);
        ValidateEmployeeId(booking.EmployeeId);
        ValidateSeatId(booking.SeatId);
    }

    private void ValidateBookingDate(DateTime bookingDate)
    {
        if (bookingDate < DateTime.Now)
        {
            throw new ArgumentException("Booking Date cannot be in past");
        }
    }

    public void ValidateEmployeeId(int employeeId)
    {
        if (employeeId < 0)
        {
            throw new ArgumentException("Employee Id must be valid");
        }
    }

    public void ValidateSeatId(int seatId)
    {
        if (seatId < 0)
        {
            throw new ArgumentException("Seat Id must be valid");
        }
    }
}
