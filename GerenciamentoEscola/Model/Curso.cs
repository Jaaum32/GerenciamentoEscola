using System.ComponentModel.DataAnnotations;

namespace GerenciamentoEscola.Model;

public class Curso
{
    public Curso(int? id, string nome, string turno)
    {
        Id = id;
        Nome = nome;
        Turno = turno;
    }

    [Key]
    public int? Id { get; set; }
    
    public string Nome { get; set; }
    public string Turno { get; set; }
    public List<Materia>? Materias { get; set; }


}