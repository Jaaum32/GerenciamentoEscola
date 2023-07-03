using GerenciamentoEscola.Interfaces;
using GerenciamentoEscola.Model;

namespace GerenciamentoEscola.Controller;

public class CCursoMateria : Repository<CursoMateria>, ICursoMateria
{
    public CursoMateria? ObterPorIds(int CursoId, int MateriaId)
    {
        return Context.Set<CursoMateria>().FirstOrDefault(u => u.CursoId == CursoId && u.MateriaId == MateriaId);
    }
    
    public void Atualizar(CursoMateria entity)
    {
        Context.Entry(Context.Set<CursoMateria>().FirstOrDefault(u=>u.CursoId == entity.CursoId && u.MateriaId == entity.MateriaId)).CurrentValues.SetValues(entity);
        Context.SaveChanges();
    }
    
    public List<CursoMateria> ObterTodosPorCursoId(int id)
    {
        return  Context.Set<CursoMateria>().Where(u => u.CursoId == id).ToList();
    }

    public List<CursoMateria> ObterTodosPorMateriaId(int id)
    {
        return Context.Set<CursoMateria>().Where(u => u.MateriaId == id).ToList();
    }
}