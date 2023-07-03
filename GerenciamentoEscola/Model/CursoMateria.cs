using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoEscola.Model;

public class CursoMateria
{
    public CursoMateria(int cursoId, int materiaId, int semestre)
    {
        CursoId = cursoId;
        MateriaId = materiaId;
        Semestre = semestre;
    }

    public int CursoId { get; set; }
    [ForeignKey("CursoId")]
    public Curso Curso { get; set; }
    
    public int MateriaId { get; set; }
    [ForeignKey("MateriaId")]
    public Materia Materia { get; set; }
    
    public int Semestre { get; set; }
}