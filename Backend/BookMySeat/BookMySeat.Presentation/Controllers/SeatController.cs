using BookMySeat.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookMySeat.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SeatController(ISeatService seatService) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetAllSeatsAsync()
    {
        var allseats= await seatService.GetAllSeatsAsync();
        return Ok(new {message="Successfull",seats=allseats});
    }
}
