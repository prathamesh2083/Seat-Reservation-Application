using BookMySeat.Application.Interfaces;
using BookMySeat.Domain.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BookMySeat.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SeatController(ISeatService seatService) : Controller
{
    [HttpPost]
    public async Task<IActionResult> AddMultipleSeatsAsync([FromBody] int seatsToAdd)
    {
        try
        {
            var seatsAdded = await seatService.AddMultipleAsync(seatsToAdd);
            return Ok(new { success = true, message = $"{seatsAdded} Seats Added Successfully" });

        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new { success = false, message = ex.Message });
        }
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveMultipleSeatsAsync([FromBody] int seatsToRemove)
    {
        try
        {
            var seatsRemoved = await seatService.RemoveMultipleAsync(seatsToRemove);
            return Ok(new { success = true, message = $"{seatsToRemove} Seats Removed Successfully" });
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new { success = false, message = ex.Message });
        }
    }
    [HttpPost("getStatus")]
    public async Task<IActionResult> GetSeatStatusAsync(string date)
    {
        try
        {
            DateTime dateTime = Convert.ToDateTime(date);
            IEnumerable<SeatStatusDTO> seatStatus = await seatService.GetSeatsStatusAsync(dateTime);
            return Ok(new { success = true, message = $" Seats Status Fetched successfully", seatStatus = seatStatus });
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new { success = false, message = ex.Message });
        }
    }
}
