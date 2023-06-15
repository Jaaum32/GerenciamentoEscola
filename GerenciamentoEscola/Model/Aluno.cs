using System.ComponentModel.DataAnnotations;
using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoEscola.Model;

public class Aluno
{
    [Key]
    public int Id { get; set; }
    
    public int NumMatricula { get; set; }
    public string Nome { get; set; }
    public string Ingresso { get; set; }
    public double Coeficiente { get; set; }
    public int Periodo { get; set; }
    public string Situacao { get; set; }
}

