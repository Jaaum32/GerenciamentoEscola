using System.ComponentModel.DataAnnotations;

namespace GerenciamentoEscola.Model;

public class Turma
{
    [Key]
    public int Id { get; set; }
    
    public Materia Materia { get; set; }
    public Professor Professor { get; set; }
    public List<Aluno> Alunos { get; set; }
    public Sala Sala { get; set; }
    public List<HoraAula> HoraAulas { get; set; }
}