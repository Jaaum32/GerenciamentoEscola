using GerenciamentoEscola.Controller;
using GerenciamentoEscola.Model;

namespace GerenciamentoEscola.Services;

public class SHoraAulaTurmas
{
    public ApplicationDbContext Context = new ApplicationDbContext();
    private readonly CHoraAula _rha = new CHoraAula();
    private readonly CTurma _rt = new CTurma();
    private readonly CSala _rs = new CSala();
    private readonly SHoraAula _sha = new SHoraAula();
    private readonly STurma _st = new STurma();
    private readonly SSala _ss = new SSala();
    private readonly CHoraAulaTurma _rhat = new CHoraAulaTurma();

    public void Inserir()
    {
        if (_rha.ObterTodos().Count == 0)
        {
            Console.WriteLine("Impossivel montar um horario sem uma hora aula");
        }
        else if (_rt.ObterTodos().Count == 0)
        {
            Console.WriteLine("Impossivel montar um horario sem uma turma");
        }
        else
        {
            Console.WriteLine("Opções: \n");
            _st.ObterTodos();
            
            int idt;
            while (true)
            {
                Console.WriteLine("DIGITE O ID DO TURMA NA QUAL SERÁ INSERIDA UMA HORA AULA E UMA SALA: ");
                while (!int.TryParse(Console.ReadLine(), out idt))
                {
                    Console.WriteLine("Id da Turma inválido. Digite um valor inteiro:");
                }

                Turma tr = _rt.ObterPorId(idt);
                if (tr != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Turma não encontrado com o ID especificado.");
                }
            }
            
            Console.WriteLine("Opções: \n");
            _sha.ObterTodos();
            
            int idh;
            while (true)
            {
                Console.WriteLine("DIGITE O ID DA HORA AULA QUE DEVE SER INSERIDA: ");
                while (!int.TryParse(Console.ReadLine(), out idh))
                {
                    Console.WriteLine("Id da Hora aula inválido. Digite um valor inteiro:");
                }

                HoraAula ha = _rha.ObterPorId(idh);
                if (ha != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hora aula não encontrado com o ID especificado.");
                }
            }
            
            Console.WriteLine("Opções: \n");
            _ss.ObterTodos();
            
            int ids;
            while (true)
            {
                Console.WriteLine("DIGITE O ID DA SALA EM QUE ESSA TURMA TERÁ AULAS: ");
                while (!int.TryParse(Console.ReadLine(), out ids))
                {
                    Console.WriteLine("Id da Sala inválido. Digite um valor inteiro:");
                }

                Sala sl = _rs.ObterPorId(ids);
                if (sl != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sala não encontrado com o ID especificado.");
                }
            }

            var turma = _rt.ObterPorId(idt);
            var horaAula = _rha.ObterPorId(idh);
            var sala = _rs.ObterPorId(ids);

            var horaAulaTurma = new HoraAulaTurma((int)horaAula.Id!, (int)turma.Id!, (int)sala.Id!);

            Context.HoraAulaTurmas.Add(horaAulaTurma);

            Context.SaveChanges();
        }
    }

    public void Atualizar()
    {
        Console.WriteLine("Opções: \n");
        _st.ObterTodos();
        
        int idt;
        while (true)
        {
            Console.WriteLine("DIGITE O ID DO TURMA: ");
            while (!int.TryParse(Console.ReadLine(), out idt))
            {
                Console.WriteLine("Id da Turma inválido. Digite um valor inteiro:");
            }

            Turma tr = _rt.ObterPorId(idt);
            if (tr != null)
            {
                break;
            }
            else
            {
                Console.WriteLine("Turma não encontrado com o ID especificado.");
            }
        }
            
        Console.WriteLine("Opções: \n");
        _sha.ObterTodos();
        
        int idh;
        while (true)
        {
            Console.WriteLine("DIGITE O ID DO HORA AULA: ");
            while (!int.TryParse(Console.ReadLine(), out idh))
            {
                Console.WriteLine("Id da Hora aula inválido. Digite um valor inteiro:");
            }

            HoraAula ha = _rha.ObterPorId(idh);
            if (ha != null)
            {
                break;
            }
            else
            {
                Console.WriteLine("Hora aula não encontrado com o ID especificado.");
            }
        }
            
        Console.WriteLine("Opções: \n");
        _ss.ObterTodos();
        
        int ids;
        while (true)
        {
            Console.WriteLine("DIGITE O ID DA SALA EM QUE ESSA TURMA TERÁ AULAS: ");
            while (!int.TryParse(Console.ReadLine(), out ids))
            {
                Console.WriteLine("Id da Sala inválido. Digite um valor inteiro:");
            }

            Sala sl = _rs.ObterPorId(ids);
            if (sl != null)
            {
                break;
            }
            else
            {
                Console.WriteLine("Sala não encontrado com o ID especificado.");
            }
        }

        var turma = _rt.ObterPorId(idt);
        var horaAula = _rha.ObterPorId(idh);
        var sala = _rs.ObterPorId(ids);
        
        var horaAulaTurma = new HoraAulaTurma((int)horaAula.Id!, (int)turma.Id!, (int)sala.Id!);
        
        _rhat.Atualizar(horaAulaTurma);

        Context.SaveChanges();
    }

    public void Excluir()
    {
        Console.WriteLine("Opções: \n");
        _st.ObterTodos();
        
        Console.WriteLine("DIGITE O ID DO TURMA: ");
        int idt;
        while (!int.TryParse(Console.ReadLine(), out idt))
        {
            Console.WriteLine("ID inválido. Digite um valor inteiro:");
        }
        
        Console.WriteLine("Opções: \n");
        _sha.ObterTodos();
        
        Console.WriteLine("DIGITE O ID DO HORA AULA: ");
        int idha;
        while (!int.TryParse(Console.ReadLine(), out idha))
        {
            Console.WriteLine("ID inválido. Digite um valor inteiro:");
        }

        HoraAulaTurma hat = _rhat.ObterPorIds(idha, idt)!;
        
        if (hat != null)
        {
            _rhat.Excluir(hat);
        }
        else
        {
            Console.WriteLine("Horario não encontrada com os IDs especificados.");
        }
        
       
    }

    public void ObterPorIds()
    {
        Console.WriteLine("DIGITE O ID DO TURMA: ");
        int idt;
        while (!int.TryParse(Console.ReadLine(), out idt))
        {
            Console.WriteLine("ID inválido. Digite um valor inteiro:");
        }
        
        Console.WriteLine("DIGITE O ID DO HORA AULA: ");
        int idha;
        while (!int.TryParse(Console.ReadLine(), out idha))
        {
            Console.WriteLine("ID inválido. Digite um valor inteiro:");
        }

        HoraAulaTurma hat = _rhat.ObterPorIds(idha, idt)!;
        
        if (hat != null)
        {
            Console.WriteLine(hat.ToString());
        }
        else
        {
            Console.WriteLine("Horario não encontrada com os IDs especificados.");
        }
    }

    public void ObterTodosHoraAulaTurmas()
    {
        Console.WriteLine("Opções: \n");
        _st.ObterTodos();
        
        Console.WriteLine("DIGITE O ID DO TURMA: ");
        int idt;
        while (!int.TryParse(Console.ReadLine(), out idt))
        {
            Console.WriteLine("ID inválido. Digite um valor inteiro:");
        }

        List<HoraAulaTurma> ats = _rhat.ObterTodosPorTurmaId(idt);

        if (ats.Count > 0)
        {
            foreach (var a in ats)
            {
                HoraAula horaAula = _rha.ObterPorId((int)a.HoraAulaId);
                Console.WriteLine(horaAula.ToString());
            }
        }
        else
        {
            Console.WriteLine("Nenhum aluno encontrado.");
        }
    }

    public void ObterTodosTurmasHoraAula()
    {
        Console.WriteLine("Opções: \n");
        _sha.ObterTodos();
        
        Console.WriteLine("DIGITE O ID DO HORA AULA: ");
        int idha;
        while (!int.TryParse(Console.ReadLine(), out idha))
        {
            Console.WriteLine("ID inválido. Digite um valor inteiro:");
        }
        
        List<HoraAulaTurma> ats = _rhat.ObterTodosPorHoraAulaId(idha);

        if (ats.Count > 0)
        {
            foreach (var a in ats)
            {
                Turma turma = _rt.ObterPorId((int)a.TurmaId);
                Console.WriteLine(turma.ToString());
            }
        }
        else
        {
            Console.WriteLine("Nenhum aluno encontrado.");
        }
    }
    
    
}