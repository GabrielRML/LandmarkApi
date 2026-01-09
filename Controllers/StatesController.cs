using LandmarkApi.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LandmarkApi.Controllers;

[ApiController]
[Route("api/states")]
public class StatesController : ControllerBase
{
    private readonly IStateService _service;

    public StatesController(IStateService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var states = await _service.GetAllAsync();
        return Ok(states);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var state = await _service.GetByIdAsync(id);
        
        if (state == null)
            return NotFound();

        return Ok(state);
    }
}
