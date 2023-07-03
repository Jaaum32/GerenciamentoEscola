using GerenciamentoEscola.Interfaces;
using GerenciamentoEscola.Model;

namespace GerenciamentoEscola.Controller;

public class CAlunoTurma : Repository<AlunoTurma>, IAlunoTurma
{
    public AlunoTurma? ObterPorIds(int AlunoId, int TurmaId)
    {
        return Context.Set<AlunoTurma>().FirstOrDefault(u => u.AlunoId == AlunoId && u.TurmaId == TurmaId);
    }
    
    public void Atualizar(AlunoTurma entity)
    {
        Context.Entry(Context.Set<AlunoTurma>().FirstOrDefault(u=>u.AlunoId == entity.AlunoId && u.TurmaId == entity.TurmaId)).CurrentValues.SetValues(entity);
        Context.SaveChanges();
    }
    
    public List<AlunoTurma> ObterTodosPorAlunoId(int id)
    {
        return  Context.Set<AlunoTurma>().Where(u => u.AlunoId == id).ToList();
    }

    public List<AlunoTurma> ObterTodosPorTurmaId(int id)
    {
        return Context.Set<AlunoTurma>().Where(u => u.TurmaId == id).ToList();
    }
}