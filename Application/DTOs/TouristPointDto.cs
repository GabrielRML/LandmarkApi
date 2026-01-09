namespace LandmarkApi.Application.DTOs;

public class TouristPointDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string IbgeCode { get; set; } = string.Empty;
    public string CityName { get; set; } = string.Empty;
    public string StateName { get; set; } = string.Empty;
    public string StateAcronym { get; set; } = string.Empty;
}
