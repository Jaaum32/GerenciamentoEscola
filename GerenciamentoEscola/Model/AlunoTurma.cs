using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GerenciamentoEscola.Controller;

namespace GerenciamentoEscola.Model;

public class AlunoTurma
{
    private readonly CTurma _rt = new CTurma();
    private readonly CMateria _rm = new CMateria();
    private readonly CAluno _ra = new CAluno();
    private readonly CAlunoTurma _rat = new CAlunoTurma();

    public override string ToString()
    {
        Aluno a = _ra.ObterPorId((int)AlunoId);
        Turma t = _rt.ObterPorId((int)TurmaId);

        return "Aluno: " + a.ToString() + "\nTurma: " + t.ToString() + "\nNota: " + Nota + "\nFaltas: " + Falta +
               "\nSituacao: " + Situacao;
    }
    
    public AlunoTurma(int? alunoId, int? turmaId, double nota, int falta)
    {
        AlunoId = alunoId;
        TurmaId = turmaId;
        Nota = nota;
        Falta = falta;

        Turma turma = _rt.ObterPorId((int)TurmaId!);
        Materia materia = _rm.ObterPorId(turma.MateriaId);
        
        double porcent = ((materia.CargaHorario - Falta) * 100) / (double) materia.CargaHorario;

        if (porcent < 75 || Nota < 60)
        {
            Situacao = "Reprovado";
        }
        else
        {
            Situacao = "Aprovado";
        }
    }

    public int? AlunoId { get; set; }
    [ForeignKey("AlunoId")]
    public Aluno Aluno { get; set; }
    
    public int? TurmaId { get; set; }
    [ForeignKey("TurmaId")]
    public Turma Turma { get; set; }
    
    public double Nota { get; set; }
    public int Falta { get; set; }
    public string Situacao { get; set; }
}