using GerenciamentoEscola.Model;

namespace GerenciamentoEscola.Interfaces;

public interface IAlunoTurma
{
    public AlunoTurma? ObterPorIds(int AlunoId, int TurmaId);

    public void Atualizar(AlunoTurma entity);

    public List<AlunoTurma> ObterTodosPorAlunoId(int id);

    public List<AlunoTurma> ObterTodosPorTurmaId(int id);
}