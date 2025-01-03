using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;

namespace Geo.Application.Dto.Request;

public class LocalRequestDto
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(75, ErrorMessage = "O nome deve ter no máximo 75 caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A categoria é obrigatória.")]
    [RegularExpression("^(Farmacia|Restaurante|Hospital|Outro)$", ErrorMessage = "Categoria inválida. Categorias permitidas: Farmacia, Restaurante, Hospital, Outro.")]
    public string Categoria { get; set; }

    [Required(ErrorMessage = "As coordenadas são obrigatórias.")]
    public CoordenadasDto Coordenadas { get; set; }
}
