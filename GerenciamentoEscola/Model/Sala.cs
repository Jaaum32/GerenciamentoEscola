using System.ComponentModel.DataAnnotations;

namespace GerenciamentoEscola.Model;

public class Sala
{
    [Key]
    public int Id { get; set; }
    
    public string Localizacao { get; set; }
    
}