using Microsoft.AspNetCore.Mvc;
using prodet_data_api.Models;

namespace prodet_data_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountryController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<CountryController> _logger;

    public CountryController(ILogger<CountryController> logger)
    {
        _logger = logger;
    }


    [HttpGet(Name = "GetCountryData")]
    public Country Get(string countryName)
    {
        return new Country();
    }
}
