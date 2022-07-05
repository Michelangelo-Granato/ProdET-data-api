using Microsoft.AspNetCore.Mvc;
using prodet_data_api.Models;

namespace prodet_data_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountryController : ControllerBase
{
    private readonly CountryContext _context;

    private readonly ILogger<CountryController> _logger;

    public CountryController(CountryContext context, ILogger<CountryController> logger)
    {
        _context = context;
        _logger = logger;
    }


    [HttpGet("{countryName}")]
    public Country Get(string countryName)
    {
        return new Country()
        {
            Name = countryName,
        };
    }
}
