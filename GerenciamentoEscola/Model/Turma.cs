using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GerenciamentoEscola.Controller;

namespace GerenciamentoEscola.Model;

public class Turma
{
    
    private readonly CMateria _rm = new CMateria();
    private readonly CProfessor _rp = new CProfessor();
    
    public override string ToString()
    {
        Materia materia = _rm.ObterPorId(MateriaId);
        Professor professor = _rp.ObterPorId(ProfessorId);

        return "Id: " + Id +
               "\nMateria:\n[" + materia.ToString() + "]" +
               "\nProfessor:\n[" + professor.ToStringTurma() + "]";
    }

    public string ToStringProf()
    {
        Materia materia = _rm.ObterPorId(MateriaId);
        
        return "Id: " + Id +
               "\nMateria:\n[" + materia.ToString() + "]";

    }

    public Turma()
    {
    }

    public Turma(int? id, int materiaId, int professorId)
    {
        Id = id;
        MateriaId = materiaId;
        ProfessorId = professorId;
    }

    [Key]
    public int? Id { get; set; }
    
    public int MateriaId { get; set; }
    [ForeignKey("MateriaId")]
    public Materia Materia { get; set; }

    public int ProfessorId { get; set; }
    [ForeignKey("ProfessorId")]
    public Professor Professor { get; set; }
    
    public IEnumerable<AlunoTurma>? Alunos { get; set; }
  //  public Sala Sala { get; set; }
    public IEnumerable<HoraAulaTurma>? HoraAulas { get; set; }
}