using GerenciamentoEscola.Controller;
using GerenciamentoEscola.Model;
using System;

namespace GerenciamentoEscola.Services
{
    public class SSala
    {
        private readonly CSala _rs = new CSala();

        public void Inserir()
        {
            Console.WriteLine("--== DIGITE OS DADOS DA SALA: ==--");
            Console.WriteLine("Localização:");
            string locate = Console.ReadLine();

            Sala sala = new Sala(null, locate);

            _rs.Inserir(sala);
        }

        public void Atualizar()
        {
            Console.WriteLine("Opções: \n");
            ObterTodos();
            
            int id;
            while (true)
            {
                Console.WriteLine("DIGITE O ID DA SALA A SER ALTERADO:");
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Id inválido. Digite um valor inteiro:");
                }

                Sala sl = _rs.ObterPorId(id);
                if (sl != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sala não encontrado com o ID especificado.");
                }
            }

            Console.WriteLine("--== DIGITE OS NOVOS DADOS DA SALA: ==--");
            Console.WriteLine("Localização:");
            string locate = Console.ReadLine();

            Sala sala = new Sala(id, locate);

            _rs.Atualizar(id, sala);
        }

        public void Excluir()
        {
            Console.WriteLine("Opções: \n");
            ObterTodos();
            
            Console.WriteLine("DIGITE O ID DA SALA A SER DELETADA: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Sala sala = _rs.ObterPorId(id);

            if (sala != null)
            {
                _rs.Excluir(sala);
            }
            else
            {
                Console.WriteLine("Sala não encontrada com o ID especificado.");
            }
        }
        public void ObterPorId()
        {
            Console.WriteLine("DIGITE O ID DA SALA A SER IMPRESSA: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Sala sala = _rs.ObterPorId(id);

            if (sala != null)
            {
                Console.WriteLine(sala.ToString());
            }
            else
            {
                Console.WriteLine("Sala não encontrada com o ID especificado.");
            }
        }

        public void ObterTodos()
        {
            List<Sala> salas = _rs.ObterTodos();

            if (salas.Count > 0)
            {
                foreach (var s in salas)
                {
                    Console.WriteLine(s.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nenhuma sala encontrada.");
            }
        }
    }
}
