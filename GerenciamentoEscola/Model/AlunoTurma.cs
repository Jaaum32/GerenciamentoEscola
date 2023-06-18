using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoEscola.Model;

public class AlunoTurma
{
    public int? AlunoId { get; set; }
    [ForeignKey("AlunoId")]
    public Aluno Aluno { get; set; }
    
    public int? TurmaId { get; set; }
    [ForeignKey("TurmaId")]
    public Turma Turma { get; set; }
    
    public double Nota { get; set; }
    public int Falta { get; set; }
    public string Situacao { get; set; }
}