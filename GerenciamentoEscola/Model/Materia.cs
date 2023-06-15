using System.ComponentModel.DataAnnotations;

namespace GerenciamentoEscola.Model;

public class Materia
{
    [Key]
    public int Id { get; set; }
    
    public string Nome { get; set; }
    public int CargaHorario { get; set; }
}