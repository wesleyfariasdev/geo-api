using AutoMapper;
using Geo.Application.Dto;
using Geo.Application.Dto.Request;
using Geo.Application.Dto.Response;
using Geo.Domain.Models;
using NetTopologySuite.Geometries;

namespace Geo.Application.Mappings;


public class Mapping : Profile
{
    public Mapping()
    {
        // Mapeamento do Point para CoordenadasDto
        CreateMap<Point, CoordenadasDto>()
            .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.Y))
            .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.X))
            .ReverseMap()
            .ConstructUsing(src => new Point(src.Longitude, src.Latitude) { SRID = 4326 });

        // Mapeamento de Local para LocalRequestDto
        CreateMap<Local, LocalRequestDto>()
            .ForMember(dest => dest.Coordenadas, opt => opt.MapFrom(src => src.Coordenadas))
            .ReverseMap()
            .ForMember(dest => dest.Coordenadas, opt => opt.MapFrom(src => src.Coordenadas));

        // Mapeamento de Local para LocalResponseDto
        CreateMap<Local, LocalResponseDto>()
            .ForMember(dest => dest.Coordenadas, opt => opt.MapFrom(src => src.Coordenadas));
    }
}
