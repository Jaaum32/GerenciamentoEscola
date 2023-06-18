using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoEscola.Model;

public class Turma
{
    public override string ToString()
    {
        return "Id: " + Id +
               "Id da Materia: " + MateriaId +
               "Id da Professor: " + ProfessorId;
    }

    public Turma()
    {
    }

    public Turma(int? id, int? materiaId, int? professorId)
    {
        Id = id;
        MateriaId = materiaId;
        ProfessorId = professorId;
    }

    [Key]
    public int? Id { get; set; }
    
    public int? MateriaId { get; set; }
    [ForeignKey("MateriaId")]
    public Materia Materia { get; set; }

    public int? ProfessorId { get; set; }
    [ForeignKey("ProfessorId")]
    public Professor Professor { get; set; }
    
    public IEnumerable<AlunoTurma>? Alunos { get; set; }
  //  public Sala Sala { get; set; }
    public IEnumerable<HoraAulaTurma>? HoraAulas { get; set; }
}