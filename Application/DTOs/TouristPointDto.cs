namespace LandmarkApi.Application.DTOs;

public class TouristPointDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public int CityId { get; set; }
    public string CityName { get; set; } = string.Empty;
    public string CityIbgeCode { get; set; } = string.Empty;
    public string StateName { get; set; } = string.Empty;
    public string StateAcronym { get; set; } = string.Empty;
    public string StateIbgeCode { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
