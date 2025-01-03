using Geo.Domain.Models;

namespace Geo.Domain.Interface;

public interface ILocalRepository
{
    Task<Local> BuscarLocalPorId(Guid id);
    Task<IEnumerable<Local>> BuscarTodos();
    Task<Local> Criar(Local local);
    Task<Local> Atualizar(Local local);
    Task<bool> Deletar(Guid id);
}
