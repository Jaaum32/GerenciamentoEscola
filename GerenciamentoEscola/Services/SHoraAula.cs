using GerenciamentoEscola.Controller;
using GerenciamentoEscola.Model;
using System;

namespace GerenciamentoEscola.Services
{
    public class SHoraAula
    {
        private readonly CHoraAula _rha = new CHoraAula();

        public void Inserir()
        {
            Console.WriteLine("--== DIGITE OS DADOS DO HORA AULA: ==--");
            Console.WriteLine("Dia da Semana: ");
            string diaSemana = Console.ReadLine();

            Console.WriteLine("Turno (M - Manhã, T - Tarde, N - Noite): ");
            char turno;
            while (!char.TryParse(Console.ReadLine(), out turno) || !ValidarTurno(turno))
            {
                Console.WriteLine("Turno inválido. Digite M para Manhã, T para Tarde ou N para Noite:");
            }

            Console.WriteLine("Horario (1 a 5):");
            int horario;
            while (!int.TryParse(Console.ReadLine(), out horario) || !ValidarHorario(horario))
            {
                Console.WriteLine("Horário inválido. Digite um número de 1 a 5:");
            }

            HoraAula horaAula = new HoraAula(null, diaSemana, turno, horario);

            _rha.Inserir(horaAula);
        }

        public void Atualizar()
        {
            Console.WriteLine("DIGITE O ID DA HORA AULA A SER ALTERADA: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            Console.WriteLine("--== DIGITE OS NOVOS DADOS DA HORA AULA: ==--");
            Console.WriteLine("Dia da Semana: ");
            string diaSemana = Console.ReadLine();

            Console.WriteLine("Turno (M - Manhã, T - Tarde, N - Noite): ");
            char turno;
            while (!char.TryParse(Console.ReadLine(), out turno) || !ValidarTurno(turno))
            {
                Console.WriteLine("Turno inválido. Digite M para Manhã, T para Tarde ou N para Noite:");
            }

            Console.WriteLine("Horario (1 a 5):");
            int horario;
            while (!int.TryParse(Console.ReadLine(), out horario) || !ValidarHorario(horario))
            {
                Console.WriteLine("Horário inválido. Digite um número de 1 a 5:");
            }

            HoraAula horaAula = new HoraAula(id, diaSemana, turno, horario);

            _rha.Atualizar(horaAula);
        }

        public void Excluir()
        {
            Console.WriteLine("DIGITE O ID DA HORA AULA A SER DELETADA: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            HoraAula horaAula = _rha.ObterPorId(id);

            if (horaAula != null)
            {
                _rha.Excluir(horaAula);
            }
            else
            {
                Console.WriteLine("Hora aula não encontrada com o ID especificado.");
            }
        }

        public void ObterPorId()
        {
            Console.WriteLine("DIGITE O ID DA HORA AULA A SER IMPRESSA: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID inválido. Digite um valor inteiro:");
            }

            HoraAula horaAula = _rha.ObterPorId(id);

            if (horaAula != null)
            {
                Console.WriteLine(horaAula.ToString());
            }
            else
            {
                Console.WriteLine("Hora aula não encontrada com o ID especificado.");
            }
        }

        public void ObterTodos()
        {
            List<HoraAula> horasAula = _rha.ObterTodos();

            if (horasAula.Count > 0)
            {
                foreach (var h in horasAula)
                {
                    Console.WriteLine(h.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nenhuma hora aula encontrada.");
            }
        }

        private bool ValidarTurno(char turno)
        {
            return turno == 'M' || turno == 'T' || turno == 'N';
        }

        private bool ValidarHorario(int horario)
        {
            return horario >= 1 && horario <= 5;
        }
    }
}
