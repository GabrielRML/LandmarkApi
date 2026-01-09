using System.ComponentModel.DataAnnotations;

namespace LandmarkApi.Domain.Entities;

public class TouristPoint
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    [MaxLength(100)]
    public string Description { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string IbgeCode { get; set; } = string.Empty;
    public string CityName { get; set; } = string.Empty;
    public string StateName { get; set; } = string.Empty;
    public string StateAcronym { get; set; } = string.Empty;
}
