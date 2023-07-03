using GerenciamentoEscola.Controller;
using GerenciamentoEscola.Model;
using System;

namespace GerenciamentoEscola.Services
{
    public class SMateria
    {
        private readonly CMateria _rm = new CMateria();

        public void Inserir()
        {
            Console.WriteLine("--== DIGITE OS DADOS DO MATERIA: ==--");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Carga Horaria: ");
            int carga;
            while (!int.TryParse(Console.ReadLine(), out carga) || carga <= 0)
            {
                Console.WriteLine("Carga horária inválida. Digite um valor inteiro positivo:");
            }

            Materia materia = new Materia(null, nome, carga);

            _rm.Inserir(materia);
        }

        public void Atualizar()
        {
            Console.WriteLine("Opções: \n");
            ObterTodos();
            
            int id;
            while (true)
            {
                Console.WriteLine("DIGITE O ID DA MATERIA A SER ALTERADA: ");
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Id inválido. Digite um valor inteiro:");
                }

                Materia mat = _rm.ObterPorId(id);
                if (mat != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Materia não encontrado com o ID especificado.");
                }
            }

            Console.WriteLine("--== DIGITE OS NOVOS DADOS DA MATERIA: ==--");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Carga Horaria: ");
            int carga;
            while (!int.TryParse(Console.ReadLine(), out carga) || carga <= 0)
            {
                Console.WriteLine("Carga horária inválida. Digite um valor inteiro positivo:");
            }

            Materia materia = new Materia(id, nome, carga);

            _rm.Atualizar(id, materia);
        }

        public void Excluir()
        {
            Console.WriteLine("Opções: \n");
            ObterTodos();
            
            Console.WriteLine("DIGITE O ID DA MATERIA A SER DELETADA: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Materia materia = _rm.ObterPorId(id);

            if (materia != null)
            {
                _rm.Excluir(materia);
            }
            else
            {
                Console.WriteLine("Matéria não encontrada com o ID especificado.");
            }
        }

        public void ObterPorId()
        {
            Console.WriteLine("DIGITE O ID DA MATERIA A SER IMPRESSA: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Materia materia = _rm.ObterPorId(id);

            if (materia != null)
            {
                Console.WriteLine(materia.ToString());
            }
            else
            {
                Console.WriteLine("Matéria não encontrada com o ID especificado.");
            }
        }

        public void ObterTodos()
        {
            List<Materia> materias = _rm.ObterTodos();

            if (materias.Count > 0)
            {
                foreach (var m in materias)
                {
                    Console.WriteLine(m.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nenhuma matéria encontrada.");
            }
        }
    }
}
