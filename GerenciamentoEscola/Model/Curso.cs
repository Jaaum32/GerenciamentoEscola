using System.ComponentModel.DataAnnotations;

namespace GerenciamentoEscola.Model;

public class Curso
{
    public override string ToString()
    {
        return "Id: " + Id +
               "Nome: " + Nome +
               "Turno: " + Turno;
    }

    public Curso()
    {
    }

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
    public IEnumerable<CursoMateria>? Materias { get; set; }


}