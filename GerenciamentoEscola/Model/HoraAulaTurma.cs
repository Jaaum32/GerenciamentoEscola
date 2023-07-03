using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoEscola.Model;

public class HoraAulaTurma
{
    public HoraAulaTurma(int? horaAulaId, int? turmaId, int? salaId)
    {
        HoraAulaId = horaAulaId;
        TurmaId = turmaId;
        SalaId = salaId;
    }

    public int? HoraAulaId { get; set; }
    [ForeignKey("HoraAulaId")]
    public HoraAula HoraAula { get; set; }
    
    public int? TurmaId { get; set; }
    [ForeignKey("TurmaId")]
    public Turma Turma { get; set; }
    
    
    public int? SalaId { get; set; }
    [ForeignKey("SalaId")]
    public Sala Sala { get; set; }
}