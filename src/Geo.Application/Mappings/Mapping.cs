using AutoMapper;
using Geo.Application.Dto.Request;
using Geo.Application.Dto.Response;
using Geo.Domain.Models;

namespace Geo.Application.Mappings;

public class Mapping : Profile
{
    public Mapping()
    {
        CreateMap<Local, LocalRequestDto>().ReverseMap();
        CreateMap<Local, LocalResponseDto>().ReverseMap();
    }
}
