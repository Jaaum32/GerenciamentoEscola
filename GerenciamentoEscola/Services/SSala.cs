using GerenciamentoEscola.Controller;
using GerenciamentoEscola.Model;

namespace GerenciamentoEscola.Services;

public class SSala
{
    private readonly CSala _rs = new CSala();
    
    public void Inserir(){
        Console.WriteLine("--== DIGITE OS DADOS DA SALA: ==--");
        Console.WriteLine("Localização:");
        string locate = Console.ReadLine();
        
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
