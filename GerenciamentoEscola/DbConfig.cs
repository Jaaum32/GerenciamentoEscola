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
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<CursoMateria> CursoMaterias { get; set; }
    public DbSet<AlunoTurma> AlunosTurmas { get; set; }
    public DbSet<HoraAulaTurma> HoraAulaTurmas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("Server=localhost; Database=gerenciamentoescola; User id=root; Password=0406");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CursoMateria>()
            .HasKey(m => new { m.MateriaId, m.CursoId });

        modelBuilder.Entity<CursoMateria>()
            .HasOne(m => m.Curso)
            .WithMany(a => a.Materias)
            .HasForeignKey(m => m.CursoId);

        modelBuilder.Entity<CursoMateria>()
            .HasOne(m => m.Materia)
            .WithMany(d => d.Cursos)
            .HasForeignKey(m => m.CursoId);
        
        modelBuilder.Entity<AlunoTurma>()
            .HasKey(m => new { m.AlunoId, m.TurmaId });
        
        modelBuilder.Entity<AlunoTurma>()
            .HasOne(m => m.Aluno)
            .WithMany(a => a.Turmas)
            .HasForeignKey(m => m.TurmaId);

        modelBuilder.Entity<AlunoTurma>()
            .HasOne(m => m.Turma)
            .WithMany(d => d.Alunos)
            .HasForeignKey(m => m.AlunoId);
        
        modelBuilder.Entity<HoraAulaTurma>()
            .HasKey(m => new { m.HoraAulaId, m.TurmaId });
        
        modelBuilder.Entity<HoraAulaTurma>()
            .HasOne(m => m.HoraAula)
            .WithMany(a => a.Turmas)
            .HasForeignKey(m => m.TurmaId);

        modelBuilder.Entity<HoraAulaTurma>()
            .HasOne(m => m.Turma)
            .WithMany(d => d.HoraAulas)
            .HasForeignKey(m => m.HoraAulaId);
        

        // outras configurações

        base.OnModelCreating(modelBuilder);
    }
}