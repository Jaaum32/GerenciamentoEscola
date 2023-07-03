using GerenciamentoEscola.Controller;
using GerenciamentoEscola.Model;

namespace GerenciamentoEscola.Services
{
    public class STurma
    {
        private readonly CTurma _rt = new CTurma();
        private readonly CProfessor _rp = new CProfessor();
        private readonly CMateria _rm = new CMateria();
        private readonly SProfessor _sp = new SProfessor();
        private readonly SMateria _sm = new SMateria();

        public void Inserir()
        {
            if (_rp.ObterTodos().Count == 0)
            {
                Console.WriteLine("Impossivel adicionar uma turma sem nenhum professor");
            }
            else if (_rm.ObterTodos().Count == 0)
            {
                Console.WriteLine("Impossivel adicionar uma turma sem nenhuma matéria");
            }
            else
            {
                Console.WriteLine("--== DIGITE OS DADOS DA TURMA: ==--");
                
                Console.WriteLine("Opções: \n");
                _sm.ObterTodos();
                
                int idm;
                while (true)
                {
                    Console.WriteLine("DIGITE O NOVO ID DA MATERIA: ");
                    while (!int.TryParse(Console.ReadLine(), out idm))
                    {
                        Console.WriteLine("Id da matéria inválido. Digite um valor inteiro:");
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
                
                Console.WriteLine("Opções: \n");
                _sp.ObterTodos();

                int idp;
                while (true)
                {
                    Console.WriteLine("DIGITE O NOVO ID DO PROFESSOR: ");
                    while (!int.TryParse(Console.ReadLine(), out idp))
                    {
                        Console.WriteLine("Id inválido. Digite um valor inteiro:");
                    }

                    Professor pr = _rp.ObterPorId(idp);
                    if (pr != null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Professor não encontrado com o ID especificado.");
                    }
                }

                Turma turma = new Turma(null, idm, idp);

                _rt.Inserir(turma);
            }
        }

        public void Atualizar()
        {
            Console.WriteLine("Opções: \n");
            ObterTodos();
            
            int id;
            while (true)
            {
                Console.WriteLine("DIGITE O ID DO TURMA A SER ALTERADO:");
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Id inválido. Digite um valor inteiro:");
                }

                Turma tr = _rt.ObterPorId(id);
                if (tr != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Turma não encontrado com o ID especificado.");
                }
            }

            Console.WriteLine("--== DIGITE OS NOVOS DADOS DA TURMA: ==--");
            
            Console.WriteLine("Opções: \n");
            _sm.ObterTodos();
            
            int idm;
            while (true)
            {
                Console.WriteLine("DIGITE O NOVO ID DA MATERIA: ");
                while (!int.TryParse(Console.ReadLine(), out idm))
                {
                    Console.WriteLine("Id da matéria inválido. Digite um valor inteiro:");
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

            Console.WriteLine("Opções: \n");
            _sp.ObterTodos();
            
            int idp;
            while (true)
            {
                Console.WriteLine("DIGITE O NOVO ID DO PROFESSOR: ");
                while (!int.TryParse(Console.ReadLine(), out idp))
                {
                    Console.WriteLine("Id inválido. Digite um valor inteiro:");
                }

                Professor pr = _rp.ObterPorId(idp);
                if (pr != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Professor não encontrado com o ID especificado.");
                }
            }

            Turma turma = new Turma(id, idm, idp);

            _rt.Atualizar(id, turma);
        }

        public void Excluir()
        {
            Console.WriteLine("Opções: \n");
            ObterTodos();
            
            Console.WriteLine("DIGITE O ID DA TURMA A SER DELETADA: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Turma turma = _rt.ObterPorId(id);

            if (turma != null)
            {
                _rt.Excluir(turma);
            }
            else
            {
                Console.WriteLine("Turma não encontrada com o ID especificado.");
            }
        }

        public void ObterPorId()
        {
            Console.WriteLine("DIGITE O ID DA TURMA A SER IMPRESSA: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Turma turma = _rt.ObterPorId(id);

            if (turma != null)
            {
                Console.WriteLine(turma.ToString());
            }
            else
            {
                Console.WriteLine("Turma não encontrada com o ID especificado.");
            }
        }

        public void ObterTodos()
        {
            List<Turma> turmas = _rt.ObterTodos();

            if (turmas.Count > 0)
            {
                foreach (var t in turmas)
                {
                    Console.WriteLine(t.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nenhuma turma encontrada.");
            }
        }
    }
}