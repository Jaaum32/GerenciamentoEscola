using ConsoleTables;
using GerenciamentoEscola.Controller;
using GerenciamentoEscola.Model;

namespace GerenciamentoEscola.Services;

public class SCursoMateria
{
    public ApplicationDbContext Context = new ApplicationDbContext();
    private readonly CCurso _rc = new CCurso();
    private readonly CMateria _rm = new CMateria();
    private readonly SCurso _sc = new SCurso();
    private readonly SMateria _sm = new SMateria();
    private readonly CCursoMateria _rcm = new CCursoMateria();

    public void Inserir()
    {
        if (_rc.ObterTodos().Count == 0)
        {
            Console.WriteLine("Impossivel fazer cadastro na matriz sem nenhum curso");
        }
        else if (_rm.ObterTodos().Count == 0)
        {
            Console.WriteLine("Impossivel fazer cadastro na matriz sem nenhuma materia");
        }
        else
        {
            Console.WriteLine("Opções: \n");
            _sc.ObterTodos();
            
            int idc;
            while (true)
            {
                Console.WriteLine("DIGITE O ID DO CURSO NA QUAL A MATERIA DEVE SER INSERIDA: ");
                while (!int.TryParse(Console.ReadLine(), out idc))
                {
                    Console.WriteLine("Id da Curso inválido. Digite um valor inteiro:");
                }

                Curso cr = _rc.ObterPorId(idc);
                if (cr != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Curso não encontrado com o ID especificado.");
                }
            }
            
            Console.WriteLine("Opções: \n");
            _sm.ObterTodos();
            
            int idm;
            while (true)
            {
                Console.WriteLine("DIGITE O ID DA MATERIA QUE DEVE SER INSERIDA: ");
                while (!int.TryParse(Console.ReadLine(), out idm))
                {
                    Console.WriteLine("Id da Materia inválido. Digite um valor inteiro:");
                }

                Materia mat = _rm.ObterPorId(idm);
                if (mat != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Materia não encontrado com o ID especificado.");
                }
            }
            
            var curso = _rc.ObterPorId(idc);
            var materia = _rm.ObterPorId(idm);

            Console.WriteLine("DIGITE EM QUE SEMESTRE ESSA MATERIA SERÁ INCLUÍDA: ");
            int semestre = 0;
            while (!int.TryParse(Console.ReadLine(), out semestre))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            var cursoMateria = new CursoMateria((int)curso.Id!, (int)materia.Id!, semestre);

            Context.CursoMaterias.Add(cursoMateria);

            Context.SaveChanges();
        }
    }

    public void Atualizar()
    {
        Console.WriteLine("Opções: \n");
        _sc.ObterTodos();
        
        int idc;
        while (true)
        {
            Console.WriteLine("DIGITE O ID DO CURSO: ");
            while (!int.TryParse(Console.ReadLine(), out idc))
            {
                Console.WriteLine("Id da Curso inválido. Digite um valor inteiro:");
            }

            Curso cr = _rc.ObterPorId(idc);
            if (cr != null)
            {
                break;
            }
            else
            {
                Console.WriteLine("Curso não encontrado com o ID especificado.");
            }
        }
            
        Console.WriteLine("Opções: \n");
        _sm.ObterTodos();
        
        int idm;
        while (true)
        {
            Console.WriteLine("DIGITE O ID DA MATERIA: ");
            while (!int.TryParse(Console.ReadLine(), out idm))
            {
                Console.WriteLine("Id da Materia inválido. Digite um valor inteiro:");
            }

            Materia mat = _rm.ObterPorId(idm);
            if (mat != null)
            {
                break;
            }
            else
            {
                Console.WriteLine("Materia não encontrado com o ID especificado.");
            }
        }

        Console.WriteLine("DIGITE EM QUE SEMESTRE ESSA MATERIA SERÁ INCLUÍDA: ");
        int semestre = 0;
        while (!int.TryParse(Console.ReadLine(), out semestre))
        {
            Console.WriteLine("ID inválido. Digite um valor inteiro:");
        }

        var curso = _rc.ObterPorId(idc);
        var materia = _rm.ObterPorId(idm);
        
        var cursoMateria = new CursoMateria((int)curso.Id!, (int)materia.Id!, semestre);
        
        _rcm.Atualizar(cursoMateria);

        Context.SaveChanges();
    }

    public void Excluir()
    {
        Console.WriteLine("Opções: \n");
        _sc.ObterTodos();
        
        Console.WriteLine("DIGITE O ID DO CURSO: ");
        int idc;
        while (!int.TryParse(Console.ReadLine(), out idc))
        {
            Console.WriteLine("ID inválido. Digite um valor inteiro:");
        }
        
        Console.WriteLine("Opções: \n");
        _sm.ObterTodos();
        
        Console.WriteLine("DIGITE O ID DA MATERIA: ");
        int idm;
        while (!int.TryParse(Console.ReadLine(), out idm))
        {
            Console.WriteLine("ID inválido. Digite um valor inteiro:");
        }

        CursoMateria cm = _rcm.ObterPorIds(idc, idm)!;
        if (cm != null)
        {
            _rcm.Excluir(cm);
        }
        else
        {
            Console.WriteLine("Registro não encontrada com os IDs especificados.");
        }
    }

    public void ObterPorIds()
    {
        Console.WriteLine("DIGITE O ID DO CURSO: ");
        int idc;
        while (!int.TryParse(Console.ReadLine(), out idc))
        {
            Console.WriteLine("ID inválido. Digite um valor inteiro:");
        }
        
        Console.WriteLine("DIGITE O ID DA MATERIA: ");
        int idm;
        while (!int.TryParse(Console.ReadLine(), out idm))
        {
            Console.WriteLine("ID inválido. Digite um valor inteiro:");
        }

        CursoMateria cm = _rcm.ObterPorIds(idc, idm)!;
        if (cm != null)
        {
            Console.WriteLine(cm.ToString());
        }
        else
        {
            Console.WriteLine("Registro não encontrada com os IDs especificados.");
        }
    }

    public void ObterTodosMateriasCurso()
    {
        Console.WriteLine("Opções: \n");
        _sc.ObterTodos();
        
        Console.WriteLine("DIGITE O ID DO CURSO: ");
        int idc;
        while (!int.TryParse(Console.ReadLine(), out idc))
        {
            Console.WriteLine("ID inválido. Digite um valor inteiro:");
        }

        List<CursoMateria> ats = _rcm.ObterTodosPorCursoId(idc);
        
        if (ats.Count > 0)
        {
            foreach (var a in ats)
            {
                Materia materia = _rm.ObterPorId((int)a.CursoId);
                Console.WriteLine(materia.ToString());
            }
        }
        else
        {
            Console.WriteLine("Nenhum aluno encontrado.");
        }
    }

    public void ObterTodosCursosMateria()
    {
        Console.WriteLine("Opções: \n");
        _sm.ObterTodos();
        
        Console.WriteLine("DIGITE O ID DA MATERIA: ");
        int idm;
        while (!int.TryParse(Console.ReadLine(), out idm))
        {
            Console.WriteLine("ID inválido. Digite um valor inteiro:");
        }
        
        List<CursoMateria> ats = _rcm.ObterTodosPorMateriaId(idm);
        
        if (ats.Count > 0)
        {
            foreach (var a in ats)
            {
                Curso curso = _rc.ObterPorId((int)a.MateriaId);
                Console.WriteLine(curso.ToString());
            }
        }
        else
        {
            Console.WriteLine("Nenhum aluno encontrado.");
        }
    }
    
    public void VerMatrizCurricular()
    {
        Console.WriteLine("Opções: \n");
        _sc.ObterTodos();
        
        int idc;
        while (true)
        {
            Console.WriteLine("DIGITE O ID DO CURSO PARA VER SUA MATRIZ CURRICULAR: ");
            while (!int.TryParse(Console.ReadLine(), out idc))
            {
                Console.WriteLine("Id da Curso inválido. Digite um valor inteiro:");
            }

            Curso cr = _rc.ObterPorId(idc);
            if (cr != null)
            {
                break;
            }
            else
            {
                Console.WriteLine("Curso não encontrado com o ID especificado.");
            }
        }

        var curso = _rc.ObterPorId(idc);
        Console.WriteLine(curso.ToString());

        List<CursoMateria> cursoMateria = _rcm.ListarPorParametros("CursoMaterias", "CursoId", curso.Id.ToString());
        var tabela = new ConsoleTable("Semestre", "Nome", "Carga Horaria");
        
        foreach (var cm in cursoMateria)
        {
            var materia = _rm.ObterPorId(cm.MateriaId);
            tabela.AddRow(cm.Semestre, materia.Nome, materia.CargaHorario);
        }
        
        tabela.Write();

    }

}