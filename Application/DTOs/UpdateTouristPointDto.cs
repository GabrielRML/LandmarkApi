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

    [Required(ErrorMessage = "O código IBGE é obrigatório")]
    public string IbgeCode { get; set; } = string.Empty;

    [Required(ErrorMessage = "O nome da cidade é obrigatório")]
    public string CityName { get; set; } = string.Empty;

    [Required(ErrorMessage = "O nome do estado é obrigatório")]
    public string StateName { get; set; } = string.Empty;

    [Required(ErrorMessage = "A sigla do estado é obrigatória")]
    [StringLength(2, ErrorMessage = "A sigla do estado deve ter 2 caracteres")]
    public string StateAcronym { get; set; } = string.Empty;
}
