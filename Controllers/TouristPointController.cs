using LandmarkApi.Application.DTOs;
using LandmarkApi.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LandmarkApi.Controllers;

[ApiController]
[Route("api/tourist-points")]
public class TouristPointController : ControllerBase
{
    private readonly ITouristPointService _service;

    public TouristPointController(ITouristPointService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(TouristPointDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TouristPointDto>> GetById(Guid id)
    {
        var touristPoint = await _service.GetByIdAsync(id);
        
        if (touristPoint == null)
            return NotFound(new { message = "Ponto turístico não encontrado" });

        return Ok(touristPoint);
    }

    [HttpGet]
    [ProducesResponseType(typeof(TouristPointDto), StatusCodes.Status200OK)]
    public async Task<ActionResult> GetPaged(
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 10,
        [FromQuery] string? name = null,
        [FromQuery] string orderByCreatedAt = "desc")
    {
        if (pageNumber < 1)
            return BadRequest(new { message = "O número da página deve ser maior que 0" });

        if (pageSize < 1 || pageSize > 100)
            return BadRequest(new { message = "O tamanho da página deve estar entre 1 e 100" });

        if (orderByCreatedAt.ToLower() != "asc" && orderByCreatedAt.ToLower() != "desc")
            return BadRequest(new { message = "O parâmetro orderByCreatedAt deve ser 'asc' ou 'desc'" });

        var result = await _service.GetPagedAsync(pageNumber, pageSize, name, orderByCreatedAt);
        return Ok(result);
    }

    [HttpPost]
    [ProducesResponseType(typeof(TouristPointDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TouristPointDto>> Create([FromBody] CreateTouristPointDto createDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var touristPoint = await _service.CreateAsync(createDto);
        return CreatedAtAction(nameof(GetById), new { id = touristPoint.Id }, touristPoint);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(typeof(TouristPointDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TouristPointDto>> Update(Guid id, [FromBody] UpdateTouristPointDto updateDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var touristPoint = await _service.UpdateAsync(id, updateDto);
        
        if (touristPoint == null)
            return NotFound(new { message = "Ponto turístico não encontrado" });

        return Ok(touristPoint);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(Guid id)
    {
        var deleted = await _service.DeleteAsync(id);
        
        if (!deleted)
            return NotFound(new { message = "Ponto turístico não encontrado" });

        return NoContent();
    }
}
