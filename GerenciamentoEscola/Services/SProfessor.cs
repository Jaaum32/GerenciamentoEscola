using GerenciamentoEscola.Controller;
using GerenciamentoEscola.Model;
using System;

namespace GerenciamentoEscola.Services
{
    public class SProfessor
    {
        private readonly CProfessor _rp = new CProfessor();

        public void Inserir()
        {
            Console.WriteLine("--== DIGITE OS DADOS DO PROFESSOR: ==--");
            Console.WriteLine("Número de Matricula:");
            int nMatricula;
            while (!int.TryParse(Console.ReadLine(), out nMatricula))
            {
                Console.WriteLine("Número de matrícula inválido. Digite um valor inteiro:");
            }

            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Ingresso:");
            string ingresso = Console.ReadLine();

            Professor professor = new Professor(null, nMatricula, nome, ingresso);

            _rp.Inserir(professor);
        }

        public void Atualizar()
        {
            Console.WriteLine("DIGITE O ID DO PROFESSOR A SER ALTERADO: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Console.WriteLine("--== DIGITE OS NOVOS DADOS DO PROFESSOR: ==--");
            Console.WriteLine("Número de Matricula:");
            int nMatricula;
            while (!int.TryParse(Console.ReadLine(), out nMatricula))
            {
                Console.WriteLine("Número de matrícula inválido. Digite um valor inteiro:");
            }

            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Ingresso:");
            string ingresso = Console.ReadLine();

            Professor professor = new Professor(id, nMatricula, nome, ingresso);

            _rp.Atualizar(professor);
        }

        public void Excluir()
        {
            Console.WriteLine("DIGITE O ID DO PROFESSOR A SER DELETADO: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Professor professor = _rp.ObterPorId(id);

            if (professor != null)
            {
                _rp.Excluir(professor);
            }
            else
            {
                Console.WriteLine("Professor não encontrado com o ID especificado.");
            }
        }

        public void ObterPorId()
        {
            Console.WriteLine("DIGITE O ID DO PROFESSOR A SER IMPRESSO: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Professor professor = _rp.ObterPorId(id);

            if (professor != null)
            {
                Console.WriteLine(professor.ToString());
            }
            else
            {
                Console.WriteLine("Professor não encontrado com o ID especificado.");
            }
        }

        public void ObterTodos()
        {
            List<Professor> professores = _rp.ObterTodos();

            if (professores.Count > 0)
            {
                foreach (var p in professores)
                {
                    Console.WriteLine(p.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nenhum professor encontrado.");
            }
        }
    }
}
