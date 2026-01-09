using LandmarkApi.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LandmarkApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CitiesController : ControllerBase
{
    private readonly ICityService _service;

    public CitiesController(ICityService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var cities = await _service.GetAllAsync();
        return Ok(cities);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var city = await _service.GetByIdAsync(id);
        
        if (city == null)
            return NotFound();

        return Ok(city);
    }
}
