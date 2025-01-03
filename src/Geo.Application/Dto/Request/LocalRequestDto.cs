using System.Drawing;

namespace Geo.Application.Dto.Request;

internal class LocalRequestDto
{
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public Point Coordenadas { get; set; }
}
