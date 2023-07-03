using GerenciamentoEscola.Controller;
using GerenciamentoEscola.Model;
using System;

namespace GerenciamentoEscola.Services
{
    public class SCurso
    {
        
        private readonly CCurso _rc = new CCurso();

        public void Inserir()
        {
            Console.WriteLine("--== DIGITE OS DADOS DO CURSO: ==--");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Carga Horaria: ");
            string cargaHoraria = Console.ReadLine();

            Curso curso = new Curso(null, nome, cargaHoraria);

            _rc.Inserir(curso);
        }

        public void Atualizar()
        {
            Console.WriteLine("Opções: \n");
            ObterTodos();
            
            int id;
            while (true)
            {
                
                Console.WriteLine("DIGITE O ID DO CURSO A SER ALTERADO: ");
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Id inválido. Digite um valor inteiro:");
                }

                Curso cr = _rc.ObterPorId(id);
                if (cr != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Curso não encontrado com o ID especificado.");
                }
            }

            Console.WriteLine("--== DIGITE OS NOVOS DADOS DO CURSO: ==--");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Carga Horaria: ");
            string cargaHoraria = Console.ReadLine();

            Curso curso = new Curso(id, nome, cargaHoraria);

            _rc.Atualizar(id, curso);
        }

        public void Excluir()
        {
            Console.WriteLine("Opções: \n");
            ObterTodos();
            
            Console.WriteLine("DIGITE O ID DO CURSO A SER DELETADO: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Curso curso = _rc.ObterPorId(id);

            if (curso != null)
            {
                _rc.Excluir(curso);
            }
            else
            {
                Console.WriteLine("Curso não encontrado com o ID especificado.");
            }
        }

        public void ObterPorId()
        {
            Console.WriteLine("DIGITE O ID DO CURSO A SER IMPRESSO: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Curso curso = _rc.ObterPorId(id);

            if (curso != null)
            {
                Console.WriteLine(curso.ToString());
            }
            else
            {
                Console.WriteLine("Curso não encontrado com o ID especificado.");
            }
        }

        public void ObterTodos()
        {
            List<Curso> cursos = _rc.ObterTodos();

            if (cursos.Count > 0)
            {
                foreach (var curso in cursos)
                {
                    Console.WriteLine(curso.ToString());
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Nenhum curso encontrado.");
            }
        }
    }
}
