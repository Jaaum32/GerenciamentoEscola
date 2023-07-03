using GerenciamentoEscola.Interfaces;
using Microsoft.EntityFrameworkCore;

public class Repository<T> : IRepository<T> where T : class
{
    public ApplicationDbContext Context = new ApplicationDbContext();
    
    public T ObterPorId(int id)
    {
        return Context.Set<T>().Find(id);
    }

    public List<T> ObterTodos()
    {
        return Context.Set<T>().ToList();
    }

    public void Inserir(T entity)
    {
        Context.Set<T>().Add(entity);
        Context.SaveChanges();
    }

    public void Atualizar(T entidade)
    {
        throw new NotImplementedException();
    }

    public void Atualizar(int id, T entity)
    {
        Context.Entry(Context.Set<T>().Find(id)).CurrentValues.SetValues(entity);
        Context.SaveChanges();
    }

    public void Excluir(T entity)
    {
        Context.Set<T>().Remove(entity);
        Context.SaveChanges();
    }
    
    public List<T> ListarPorParametros(string table, string column, string? dado)
    {
        List<T> a = Context.Set<T>()
            .FromSqlRaw($"SELECT * FROM {table} Where {column} =  '{dado}'")
            .ToList();
        
        return a;
    }
    
    
}