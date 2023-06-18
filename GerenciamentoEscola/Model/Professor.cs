using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace GerenciamentoEscola.Model;

public class Professor
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
               "\nIngresso: " + Ingresso;
    }

    public Professor()
    {
    }

    public Professor(int? id, int numMatricula, string nome, string ingresso)
    {
        Id = id;
        NumMatricula = numMatricula;
        Nome = nome;
        Ingresso = ingresso;
    }

    [Key]
    public int? Id { get; set; }
    
    public int NumMatricula { get; set; }
    public string Nome { get; set; }
    public string Ingresso { get; set; }
    public List<Turma> Turmas { get; set; }

}

