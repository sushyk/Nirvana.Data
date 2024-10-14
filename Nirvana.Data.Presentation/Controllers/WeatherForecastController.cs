using Microsoft.AspNetCore.Mvc;

namespace Nirvana.Data.Presentation.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    public WeatherForecastController()
    {
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello");
    }
}
