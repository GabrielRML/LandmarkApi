namespace LandmarkApi.Application.DTOs;

public class CityDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string IbgeCode { get; set; } = string.Empty;
    public int StateId { get; set; }
    public string StateName { get; set; } = string.Empty;
    public string StateAcronym { get; set; } = string.Empty;
}
