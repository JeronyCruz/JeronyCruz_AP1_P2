using JeronyCruz_AP1_P2.DAL;
using JeronyCruz_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JeronyCruz_AP1_P2.Services;

public class RegistroServices(IDbContextFactory<Context> DbFactory)
{
    private async Task<bool> Existe(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
    }

    private async Task<bool> Insertar(Registro registro)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
    }

    private async Task<bool> Modificar(Registro registro)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
    }

    public async Task<bool> Guardar(Registro registro)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
    }

    public async Task<bool> Eliminar(Registro registro)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
    }

    public async Task<Registro> Buscar(int id)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
    }

    public async Task<List<Registro>> Listar(Expression<Func<Registro, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
    }
}
