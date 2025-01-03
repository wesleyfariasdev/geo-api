using AutoMapper;
using Geo.Application.Dto.Response;
using Geo.Application.Mappings;
using Geo.Domain.Models;
using NetTopologySuite.Geometries;


namespace Tests.Geral;

public class MappingTests
{
    private readonly IMapper _mapper;

    public MappingTests()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<Mapping>());
        _mapper = config.CreateMapper();
    }

    [Fact]
    public void Map_Local_To_LocalResponseDto_Should_Be_Valid()
    {
        var local = new Local
        {
            Nome = "Mercado Central",
            Categoria = "Restaurante",
            Coordenadas = new Point(-46.633308, -23.55052) { SRID = 4326 }
        };

        var dto = _mapper.Map<LocalResponseDto>(local);

        Assert.NotNull(dto);
        Assert.Equal("Mercado Central", dto.Nome);
        Assert.Equal("Restaurante", dto.Categoria);
        Assert.Equal(-23.55052, dto.Coordenadas.Latitude);
        Assert.Equal(-46.633308, dto.Coordenadas.Longitude);
    }
}
