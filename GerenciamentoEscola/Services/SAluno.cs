using GerenciamentoEscola.Controller;
using GerenciamentoEscola.Model;
using System;

namespace GerenciamentoEscola.Services
{
    public class SAluno
    {
        private readonly CAluno _ra = new CAluno();
        private readonly CCurso _rc = new CCurso();

        public void Inserir()
        {
            if (_rc.ObterTodos().Count == 0)
            {
                Console.WriteLine("Impossivel adicionar um aluno sem nenhum curso");
            }
            else
            {
                Console.WriteLine("--== DIGITE OS DADOS DO ALUNO: ==--");
                Console.WriteLine("Número de Matricula:");
                int nMatricula;
                while (!int.TryParse(Console.ReadLine(), out nMatricula))
                {
                    Console.WriteLine("Número de Matricula inválido. Digite um valor inteiro:");
                }

                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Ingresso:");
                string ingresso = Console.ReadLine();

                Console.WriteLine("Periodo:");
                int periodo;
                while (!int.TryParse(Console.ReadLine(), out periodo))
                {
                    Console.WriteLine("Periodo inválido. Digite um valor inteiro:");
                }

                Console.WriteLine("Situacao:");
                string situacao = Console.ReadLine();

                Console.WriteLine("Id do Curso:");
                int id;
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Id do Curso inválido. Digite um valor inteiro:");
                }

                Aluno aluno = new Aluno(null, nMatricula, nome, ingresso, periodo, situacao, id);

                _ra.Inserir(aluno);
            }
        }

        public void Atualizar()
        {
            Console.WriteLine("DIGITE O ID DO ALUNO A SER ALTERADO:");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Console.WriteLine("--== DIGITE OS NOVOS DADOS DO ALUNO: ==--");
            Console.WriteLine("Número de Matricula:");
            int nMatricula;
            while (!int.TryParse(Console.ReadLine(), out nMatricula))
            {
                Console.WriteLine("Número de Matricula inválido. Digite um valor inteiro:");
            }

            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Ingresso:");
            string ingresso = Console.ReadLine();

            Console.WriteLine("Periodo:");
            int periodo;
            while (!int.TryParse(Console.ReadLine(), out periodo))
            {
                Console.WriteLine("Periodo inválido. Digite um valor inteiro:");
            }

            Console.WriteLine("Situacao:");
            string situacao = Console.ReadLine();

            Console.WriteLine("Id do Curso:");
            int idc;
            while (!int.TryParse(Console.ReadLine(), out idc))
            {
                Console.WriteLine("Id do Curso inválido. Digite um valor inteiro:");
            }

            Aluno aluno = new Aluno(id, nMatricula, nome, ingresso, periodo, situacao, idc);

            _ra.Atualizar(aluno);
        }

        public void Excluir()
        {
            Console.WriteLine("DIGITE O ID DO ALUNO A SER DELETADO:");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Aluno aluno = _ra.ObterPorId(id);

            if (aluno != null)
            {
                _ra.Excluir(aluno);
            }
            else
            {
                Console.WriteLine("Aluno não encontrado com o ID especificado.");
            }
        }

        public void ObterPorId()
        {
            Console.WriteLine("DIGITE O ID DO ALUNO A SER IMPRESSO:");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Aluno aluno = _ra.ObterPorId(id);

            if (aluno != null)
            {
                Console.WriteLine(aluno.ToString());
            }
            else
            {
                Console.WriteLine("Aluno não encontrado com o ID especificado.");
            }
        }

        public void ObterTodos()
        {
            List<Aluno> alunos = _ra.ObterTodos();

            if (alunos.Count > 0)
            {
                foreach (var aluno in alunos)
                {
                    Console.WriteLine(aluno.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nenhum aluno encontrado.");
            }
        }
    }
}
