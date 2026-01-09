using System.ComponentModel.DataAnnotations;

namespace LandmarkApi.Domain.Entities;

public class State
{
    public int Id { get; set; }
    [MaxLength(2)]
    public string Acronym { get; set; } = string.Empty;
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    public string IbgeCode { get; set; } = string.Empty;
    
    public ICollection<City> Cities { get; set; } = new List<City>();
}
