using GerenciamentoEscola.Controller;
using GerenciamentoEscola.Model;
using System;

namespace GerenciamentoEscola.Services
{
    public class SAluno
    {
        private readonly CAluno _ra = new CAluno();
        private readonly CCurso _rc = new CCurso();
        private readonly SCurso _sc = new SCurso();

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

                Console.WriteLine("Opções: \n");
                _sc.ObterTodos();

                int idc;
                while (true)
                {
                    Console.WriteLine("Id do Curso:");
                    while (!int.TryParse(Console.ReadLine(), out idc))
                    {
                        Console.WriteLine("Id do Curso inválido. Digite um valor inteiro:");
                    }

                    Curso curso = _rc.ObterPorId(idc);
                    if (curso != null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Curso não encontrado com o ID especificado.");
                    }
                }

                Aluno aluno = new Aluno(null, nMatricula, nome, ingresso, periodo, situacao, idc);

                _ra.Inserir(aluno);
            }
        }

        public void Atualizar()
        {
            Console.WriteLine("Opções: \n");
            ObterTodos();

            int id;
            while (true)
            {
                Console.WriteLine("DIGITE O ID DO ALUNO A SER ALTERADO:");
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Id inválido. Digite um valor inteiro:");
                }

                Aluno al = _ra.ObterPorId(id);
                if (al != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado com o ID especificado.");
                }
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

            Console.WriteLine("Opções: \n");
            _sc.ObterTodos();

            int idc;
            while (true)
            {
                Console.WriteLine("Id do Curso:");
                while (!int.TryParse(Console.ReadLine(), out idc))
                {
                    Console.WriteLine("Id do Curso inválido. Digite um valor inteiro:");
                }

                Curso curso = _rc.ObterPorId(idc);
                if (curso != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Curso não encontrado com o ID especificado.");
                }
            }


            Aluno aluno = new Aluno(id, nMatricula, nome, ingresso, periodo, situacao, idc);

            _ra.Atualizar(id, aluno);
        }

        public void Excluir()
        {
            Console.WriteLine("Opções: \n");
            ObterTodos();

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
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Nenhum aluno encontrado.");
            }
        }
    }
}

