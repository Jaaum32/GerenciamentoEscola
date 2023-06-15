using GerenciamentoEscola.Interfaces;

namespace GerenciamentoEscola.Controller;

public class Repository<T> : IRepository<T> where T : class
{
    public void Inserir(T entidade)
    {
        throw new NotImplementedException();
    }

    public void Atualizar(T entidade)
    {
        throw new NotImplementedException();
    }

    public void Excluir(T entidade)
    {
        throw new NotImplementedException();
    }

    public T ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public List<T> ObterTodos()
    {
        throw new NotImplementedException();
    }
}