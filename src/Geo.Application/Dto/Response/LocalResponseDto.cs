using NetTopologySuite.Geometries;

namespace Geo.Application.Dto.Response;

public class LocalResponseDto
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public CoordenadasDto Coordenadas { get; set; }
}


