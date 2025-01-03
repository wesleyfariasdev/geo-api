using Geo.Application.Dto.Response;
using Geo.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Geral;

public class LocalResponseDtoTests
{
    [Fact]
    public void LocalResponseDto_Should_Contain_Valid_Properties()
    {
        var localResponseDto = new LocalResponseDto
        {
            Id = Guid.NewGuid(),
            Nome = "Mercado Central",
            Categoria = "Restaurante",
            Coordenadas = new CoordenadasDto
            {
                Latitude = -23.55052,
                Longitude = -46.633308
            }
        };

        Assert.NotNull(localResponseDto);
        Assert.Equal("Mercado Central", localResponseDto.Nome);
        Assert.Equal("Restaurante", localResponseDto.Categoria);
        Assert.Equal(-23.55052, localResponseDto.Coordenadas.Latitude);
        Assert.Equal(-46.633308, localResponseDto.Coordenadas.Longitude);
        Assert.IsType<Guid>(localResponseDto.Id);
    }
}
