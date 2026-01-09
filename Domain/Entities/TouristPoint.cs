using System.ComponentModel.DataAnnotations;

namespace LandmarkApi.Domain.Entities;

public class TouristPoint
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    [MaxLength(100)]
    public string Description { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    
    public int CityId { get; set; }
    public City City { get; set; } = null!;
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
