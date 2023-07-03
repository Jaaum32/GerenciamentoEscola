using GerenciamentoEscola.Interfaces;
using GerenciamentoEscola.Model;

namespace GerenciamentoEscola.Controller;

public class CHoraAulaTurma : Repository<HoraAulaTurma>, IHoraAulaTurma
{
    public HoraAulaTurma? ObterPorIds(int HoraAulaId, int TurmaId)
    {
        return Context.Set<HoraAulaTurma>().FirstOrDefault(u => u.HoraAulaId == HoraAulaId && u.TurmaId == TurmaId);
    }
    
    public void Atualizar(HoraAulaTurma entity)
    {
        Context.Entry(Context.Set<HoraAulaTurma>().FirstOrDefault(u=>u.HoraAulaId == entity.HoraAulaId && u.TurmaId == entity.TurmaId)).CurrentValues.SetValues(entity);
        Context.SaveChanges();
    }
    
    public List<HoraAulaTurma> ObterTodosPorHoraAulaId(int id)
    {
        return  Context.Set<HoraAulaTurma>().Where(u => u.HoraAulaId == id).ToList();
    }

    public List<HoraAulaTurma> ObterTodosPorTurmaId(int id)
    {
        return Context.Set<HoraAulaTurma>().Where(u => u.TurmaId == id).ToList();
    }
}