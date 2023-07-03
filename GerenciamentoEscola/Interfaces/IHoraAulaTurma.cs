using GerenciamentoEscola.Model;

namespace GerenciamentoEscola.Interfaces;

public interface IHoraAulaTurma
{
    public HoraAulaTurma? ObterPorIds(int HoraAulaId, int TurmaId);
    
    public void Atualizar(HoraAulaTurma entity);

    public List<HoraAulaTurma> ObterTodosPorHoraAulaId(int id);

    public List<HoraAulaTurma> ObterTodosPorTurmaId(int id);

}