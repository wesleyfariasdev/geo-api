using Geo.Domain.Interface;
using Geo.Domain.Models;
using Geo.Infra.Data.GeoContext;
using Microsoft.EntityFrameworkCore;

namespace Geo.Infra.Data.Repository;

public class LocalRepository(Context _context) : ILocalRepository
{
    public async Task<Local> Criar(Local local)
    {
        if (local == null) throw new ArgumentNullException(nameof(local));

        await _context.Locais.AddAsync(local);
        await _context.SaveChangesAsync();

        return local;
    }

    public async Task<Local> BuscarLocalPorId(Guid id)
    {
        return await _context.Locais
            .FirstOrDefaultAsync(l => l.Id == id);
    }

    public async Task<IEnumerable<Local>> BuscarTodos()
    {
        return await _context.Locais.ToListAsync();
    }

    public async Task<Local> Atualizar(Local local)
    {
        if (local == null) throw new ArgumentNullException(nameof(local));

        var existente = await _context.Locais.FindAsync(local.Id);
        if (existente == null) throw new KeyNotFoundException("Local não encontrado.");

        existente.Nome = local.Nome;
        existente.Categoria = local.Categoria;
        existente.Coordenadas = local.Coordenadas;

        _context.Locais.Update(existente);
        await _context.SaveChangesAsync();

        return existente;
    }

    public async Task<bool> Deletar(Guid id)
    {
        var local = await _context.Locais.FindAsync(id);
        if (local == null) return false;

        _context.Locais.Remove(local);
        await _context.SaveChangesAsync();

        return true;
    }
}