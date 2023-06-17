using System.ComponentModel.DataAnnotations;
using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoEscola.Model;

public class Aluno
{
    public Aluno(int? id, int numMatricula, string nome, string ingresso, int periodo, string situacao, Curso curso)
    {
        Id = id;
        NumMatricula = numMatricula;
        Nome = nome;
        Ingresso = ingresso;
        Periodo = periodo;
        Situacao = situacao;
        Curso = curso;
    }

    [Key]
    public int? Id { get; set; }
    
    public int NumMatricula { get; set; }
    public string Nome { get; set; }
    public string Ingresso { get; set; }
    public double Coeficiente { get; set; }
    public int Periodo { get; set; }
    public string Situacao { get; set; }
    public List<Turma> Turmas { get; set; }
    public Curso Curso { get; set; }
}

