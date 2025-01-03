using AutoMapper;
using Geo.Application.Dto.Request;
using Geo.Application.Dto.Response;
using Geo.Domain.Models;

namespace Geo.Application.Mappings;

internal class Mapping : Profile
{
    public Mapping()
    {
        CreateMap<Local, LocalRequestDto>().ReverseMap();
        CreateMap<Local, LocalResponseDto>().ReverseMap();
    }
}
