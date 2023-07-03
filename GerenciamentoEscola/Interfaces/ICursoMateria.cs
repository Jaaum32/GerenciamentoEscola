using GerenciamentoEscola.Model;

namespace GerenciamentoEscola.Interfaces;

public interface ICursoMateria
{
    public CursoMateria? ObterPorIds(int CursoId, int MateriaId);

    public void Atualizar(CursoMateria entity);

    public List<CursoMateria> ObterTodosPorCursoId(int id);

    public List<CursoMateria> ObterTodosPorMateriaId(int id);
}