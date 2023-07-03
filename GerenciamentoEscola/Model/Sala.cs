using System.ComponentModel.DataAnnotations;

namespace GerenciamentoEscola.Model;

public class Sala
{
    public override string ToString()
    {
        return "Id: " + Id + 
               "\nLocalização: " + Localizacao;
    }

    public Sala()
    {
    }

    public Sala(int? id, string localizacao)
    {
        Id = id;
        Localizacao = localizacao;
    }

    [Key]
    public int? Id { get; set; }
    
    public string Localizacao { get; set; }
    
}