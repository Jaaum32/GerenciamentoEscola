using System.ComponentModel.DataAnnotations;

namespace GerenciamentoEscola.Model;

public class Materia
{
    public override string ToString()
    {
        return "Id: " + Id +
               "\nNome: " + Nome +
               "\nCarga Horaria: " + CargaHorario;
    }

    public Materia()
    {
    }

    public Materia(int? id, string nome, int cargaHorario)
    {
        Id = id;
        Nome = nome;
        CargaHorario = cargaHorario;
    }

    [Key]
    public int? Id { get; set; }
    
    public string Nome { get; set; }
    public int CargaHorario { get; set; }
    public IEnumerable<CursoMateria>? Cursos { get; set; }
 }