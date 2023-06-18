using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace GerenciamentoEscola.Model;

public class Aluno
{
    public void ListarTurmas()
    {
        foreach (var t in Turmas)
        {
            t.ToString();
        }
    }
    public override string ToString()
    {
        return "Id: " + Id +
               "\nNumero Matricula: " + NumMatricula +
               "\nNome: " + Nome +
               "\nIngresso: " + Ingresso +
               "\nPeriodo: " + Periodo +
               "\nCoeficiente: " + Coeficiente +
               "\nSituacao: " + Situacao +
               "\nCurso: " + Curso;
    }

    public Aluno()
    {
    }

    public Aluno(int? id, int numMatricula, string nome, string ingresso, int periodo, string situacao, int? curso)
    {
        Id = id;
        NumMatricula = numMatricula;
        Nome = nome;
        Ingresso = ingresso;
        Periodo = periodo;
        Situacao = situacao;
        CursoId = curso;
    }

    [Key]
    public int? Id { get; set; }
    
    public int NumMatricula { get; set; }
    public string Nome { get; set; }
    public string Ingresso { get; set; }
    public double Coeficiente { get; set; }
    public int Periodo { get; set; }
    public string Situacao { get; set; }
    public IEnumerable<AlunoTurma>? Turmas { get; set; }
    
    public int? CursoId { get; set; }
    
    [ForeignKey("CursoId")]
    public Curso Curso { get; set; }
}



