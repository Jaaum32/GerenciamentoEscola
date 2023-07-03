using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GerenciamentoEscola.Controller;

namespace GerenciamentoEscola.Model;

public class Aluno
{
    private readonly CCurso _rc = new CCurso();
    public override string ToString()
    {
        Curso curso = _rc.ObterPorId(CursoId);
        
        return "Id: " + Id +
               "\nNumero Matricula: " + NumMatricula +
               "\nNome: " + Nome +
               "\nIngresso: " + Ingresso +
               "\nPeriodo: " + Periodo +
               "\nSituacao: " + Situacao +
               "\nCurso:\n[" + curso.ToString() + "]"; 
    }

    public Aluno()
    {
    }

    public Aluno(int? id, int numMatricula, string nome, string ingresso, int periodo, string situacao, int curso)
    {
        Id = id;
        NumMatricula = numMatricula;
        Nome = nome;
        Ingresso = ingresso;
        Periodo = periodo;
        Situacao = situacao;
        CursoId = curso;
    }

    public Aluno(int? id, double coeficiente)
    {
        Id = id;
        Coeficiente = coeficiente;
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
    
    public int CursoId { get; set; }
    
    [ForeignKey("CursoId")]
    public Curso Curso { get; set; }
}



