using Geo.Application.Dto.Request;
using Geo.Application.Dto.Response;

namespace Geo.Application.Services.IService;

public interface ILocalService
{
    Task<LocalResponseDto> BuscarLocalPorId(Guid id);
    Task<IEnumerable<LocalResponseDto>> BuscarTodos();
    Task<LocalResponseDto> Criar(LocalRequestDto local);
    Task<LocalResponseDto> Atualizar(LocalRequestDto local);
    Task<bool> Deletar(Guid id);
}
