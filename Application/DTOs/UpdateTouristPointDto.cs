using System.ComponentModel.DataAnnotations;

namespace LandmarkApi.Application.DTOs;

public class UpdateTouristPointDto
{
    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(200, ErrorMessage = "O nome deve ter no máximo 200 caracteres")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "A descrição é obrigatória")]
    [StringLength(100, ErrorMessage = "A descrição deve ter no máximo 100 caracteres")]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "A localização é obrigatória")]
    public string Location { get; set; } = string.Empty;

    [Required(ErrorMessage = "O ID da cidade é obrigatório")]
    public int CityId { get; set; }
}
