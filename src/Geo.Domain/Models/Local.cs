using System.Drawing;

namespace Geo.Domain.Models;

public class Local
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public Point Coordenadas { get; set; }
}
