using System.ComponentModel.DataAnnotations;
using GerenciamentoEscola.Controller;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace GerenciamentoEscola.Model;

public class Professor
{
    
    private readonly CTurma _rt = new CTurma();
    public override string ToString()
    {
        List<Turma> turmas = _rt.ListarPorParametros("Turmas", "ProfessorId", this.Id.ToString());
        string aux = "";
        
        foreach (var t in turmas)
        {
            aux += t.ToStringProf();
        }
        
        return "Id: " + Id +
               "\nNumero Matricula: " + NumMatricula +
               "\nNome: " + Nome +
               "\nIngresso: " + Ingresso +
               "\nTurmas: [ " + aux + "]";
    }

    public string ToStringTurma()
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

