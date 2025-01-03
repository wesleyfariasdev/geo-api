using Geo.Application.Dto;
using Geo.Application.Dto.Request;
using System.ComponentModel.DataAnnotations;

namespace Tests.Geral;

public class LocalTestRequestDtoTest
{
    [Fact]
    public void LocalRequestDto_Should_Fail_When_Nome_Is_Empty()
    {
        var dto = new LocalRequestDto
        {
            Nome = "",
            Categoria = "Restaurante",
            Coordenadas = new CoordenadasDto { Latitude = -23.55052, Longitude = -46.633308 }
        };

        var context = new ValidationContext(dto);
        var results = new List<ValidationResult>();
        var isValid = Validator.TryValidateObject(dto, context, results, true);

        Assert.False(isValid);
        Assert.Contains(results, r => r.ErrorMessage.Contains("O nome é obrigatório."));

    }
}