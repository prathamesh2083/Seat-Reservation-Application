namespace BookMySeat.Infrastructure.Database.SqlQueries;

public static class SeatSQLQueries
{
    public static string GetAllSeats = "use BookMySeatDB; select * from seat";

    public static string AddSeatQuery(int seatNumber)
    {
        return $"INSERT INTO Seat VALUES {seatNumber};";
    }
    public static string AddMultipleSeatsQuery(List<int> seatNumbers)
    {
        var seatValues = string.Join(", ", seatNumbers.Select(n => $"({n})"));
        return $"INSERT INTO Seat VALUES {seatValues};";
    }
    public static string RemoveSeatQuery(int seatNumber)
    {
        return $"DELETE FROM Seat WHERE SeatNumber = {seatNumber};";
    }
    public static string RemoveMultipleSeatsQuery(List<int> seatNumbers)
    {
        var seatValues = string.Join(", ", seatNumbers);
        return $"DELETE FROM Seat WHERE SeatNumber in ({seatValues});";
    }
    public static string GetSeatsStatusQuery(DateTime date)
    {
        return "seatStatusQuery";
    }
}
