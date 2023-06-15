using System.ComponentModel.DataAnnotations;

namespace GerenciamentoEscola.Model;

public class HoraAula
{
    [Key]
    public int Id { get; set; }
    
    public string DiaSemana { get; set; }
    public char Turno { get; set; }
    public int Horario { get; set; }
    public string HoraInicio { get; set; }
    public string HoraFim { get; set; }
}