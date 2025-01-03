using System.Drawing;

namespace Geo.Application.Dto.Request;

public class LocalRequestDto
{
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public Point Coordenadas { get; set; }
}
