using GerenciamentoEscola.Model;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<Professor> Professores{ get; set; }
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Materia> Materias { get; set; }
    public DbSet<Turma> Turmas { get; set; }
    public DbSet<HoraAula> HoraAulas { get; set; }
    public DbSet<Sala> Salas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("Data Source=gerenciamentoescola.db");
    }
}