using GerenciamentoEscola.Controller;
using GerenciamentoEscola.Model;
using System;

namespace GerenciamentoEscola.Services
{
    public class STurma
    {
        private readonly CTurma _rt = new CTurma();
        private readonly CProfessor _rp = new CProfessor();
        private readonly CMateria _rm = new CMateria();

        public void Inserir()
        {
            if (_rp.ObterTodos().Count == 0)
            {
                Console.WriteLine("Impossivel adicionar uma turma sem nenhum professor");
            } else if (_rm.ObterTodos().Count == 0)
            {
                Console.WriteLine("Impossivel adicionar uma turma sem nenhuma matéria");
            }
            else
            {
                Console.WriteLine("--== DIGITE OS DADOS DA TURMA: ==--");
                Console.WriteLine("DIGITE O ID DA MATERIA: ");
                int idm;
                while (!int.TryParse(Console.ReadLine(), out idm))
                {
                    Console.WriteLine("ID inválido. Digite um valor inteiro:");
                }

                Console.WriteLine("DIGITE O ID DO PROFESSOR: ");
                int idp;
                while (!int.TryParse(Console.ReadLine(), out idp))
                {
                    Console.WriteLine("ID inválido. Digite um valor inteiro:");
                }

                Turma turma = new Turma(null, idm, idp);

                _rt.Inserir(turma);
            }
        }

        public void Atualizar()
        {
            Console.WriteLine("DIGITE O ID DA TURMA A SER ALTERADA: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Console.WriteLine("--== DIGITE OS NOVOS DADOS DA TURMA: ==--");
            Console.WriteLine("DIGITE O NOVO ID DA MATERIA: ");
            int idm;
            while (!int.TryParse(Console.ReadLine(), out idm))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Console.WriteLine("DIGITE O NOVO ID DO PROFESSOR: ");
            int idp;
            while (!int.TryParse(Console.ReadLine(), out idp))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Turma turma = new Turma(id, idm, idp);

            _rt.Atualizar(turma);
        }

        public void Excluir()
        {
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
