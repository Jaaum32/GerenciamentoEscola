using GerenciamentoEscola.Controller;
using GerenciamentoEscola.Model;

namespace GerenciamentoEscola.Services;

public class SAluno
{
    private readonly CAluno _rs = new CAluno();
    private readonly CCurso _rc = new CCurso();
    
    public void Inserir(){
        Console.WriteLine("--== DIGITE OS DADOS DA SALA: ==--");
        Console.WriteLine("Número de Matricula:");
        int nMatricula = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Nome:");
        string nome = Console.ReadLine();
        
        Console.WriteLine("Ingresso:");
        string ingresso = Console.ReadLine();
        
        Console.WriteLine("Periodo:");
        string periodo = Console.ReadLine();
        
        Console.WriteLine("Situacao:");
        string situacao = Console.ReadLine();
        
        Console.WriteLine("Localização:");
        string locate = Console.ReadLine();
        
        Console.WriteLine("Id da Curso: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Curso curso = _rc.ObterPorId(id);
        
        Sala sala = new Sala(null, locate);

        _rs.Inserir(sala);
    }

    public void Atualizar()
    {
        Console.WriteLine("DIGITE O ID DA SALA A SER ALTERADA: ");
        int id = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("--== DIGITE OS NOVOS DADOS DA ALTERNATIVA: ==--");
        Console.WriteLine("Localização:");
        string locate = Console.ReadLine();
        
        Sala sala = new Sala(id, locate);

        _rs.Atualizar(sala);
    }

    public void Excluir()
    {
        Console.WriteLine("DIGITE O ID DA SALA A SER DELETADA: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Sala sala = _rs.ObterPorId(id);

        _rs.Excluir(sala);
    }

    public void ObterPorId()
    {
        Console.WriteLine("DIGITE O ID DA SALA A SER IMPRESSA: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Sala sala = _rs.ObterPorId(id);

        Console.WriteLine(sala.ToString());
    }

    public void ObterTodos()
    {
        List<Sala> salas = _rs.ObterTodos();

        foreach (var sala in salas)
        {
            Console.WriteLine(sala.ToString());
        }
    }
}