using Microsoft.AspNetCore.Mvc;

namespace BookMySeat.Presentation.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(new {name="prathamesh",college="pccoe" });
        }
    }
}
