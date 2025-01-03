using AutoMapper;
using Geo.Application.Dto.Request;
using Geo.Application.Dto.Response;
using Geo.Application.Services.IService;
using Geo.Domain.Interface;
using Geo.Domain.Models;

namespace Geo.Application.Services;

public class LocalServices(ILocalRepository _localRepository, IMapper _mapper) : ILocalService
{
    public async Task<LocalResponseDto> Criar(LocalRequestDto localDto)
    {
        if (localDto == null) throw new ArgumentNullException(nameof(localDto));

        var localEntity = _mapper.Map<Local>(localDto);
        var localCriado = await _localRepository.Criar(localEntity);

        return _mapper.Map<LocalResponseDto>(localCriado);
    }

    public async Task<LocalResponseDto> BuscarLocalPorId(Guid id)
    {
        var local = await _localRepository.BuscarLocalPorId(id);
        if (local == null) throw new KeyNotFoundException("Local não encontrado.");

        return _mapper.Map<LocalResponseDto>(local);
    }

    public async Task<IEnumerable<LocalResponseDto>> BuscarTodos()
    {
        var locais = await _localRepository.BuscarTodos();
        return _mapper.Map<IEnumerable<LocalResponseDto>>(locais);
    }

    public async Task<LocalResponseDto> Atualizar(LocalRequestDto localDto)
    {
        if (localDto == null) throw new ArgumentNullException(nameof(localDto));

        var localEntity = _mapper.Map<Local>(localDto);
        var localAtualizado = await _localRepository.Atualizar(localEntity);
        return _mapper.Map<LocalResponseDto>(localAtualizado);
    }

    public async Task<bool> Deletar(Guid id)
    {
        var sucesso = await _localRepository.Deletar(id);
        if (!sucesso) throw new KeyNotFoundException("Local não encontrado para exclusão.");

        return sucesso;
    }
}
