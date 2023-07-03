using GerenciamentoEscola.Controller;
using GerenciamentoEscola.Model;
using System;
using ConsoleTables;

namespace GerenciamentoEscola.Services
{
    public class SProfessor
    {
        private readonly CProfessor _rp = new CProfessor();
        private readonly CTurma _rt = new CTurma();
        private readonly CHoraAulaTurma _rhat = new CHoraAulaTurma();
        private readonly CSala _rs = new CSala();
        private readonly CHoraAula _rha = new CHoraAula();
        private readonly CMateria _rm = new CMateria();

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
            Console.WriteLine("Opções: \n");
            ObterTodos();
            
            int id;
            while (true)
            {
                Console.WriteLine("DIGITE O ID DO PROFESSOR A SER ALTERADO:");
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Id inválido. Digite um valor inteiro:");
                }

                Professor pr = _rp.ObterPorId(id);
                if (pr != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Professor não encontrado com o ID especificado.");
                }
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

            _rp.Atualizar(id, professor);
        }

        public void Excluir()
        {
            Console.WriteLine("Opções: \n");
            ObterTodos();
            
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
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Nenhum professor encontrado.");
            }
        }

        public void VerHorarioProfessor()
        {
            Console.WriteLine("Opções: \n");
            ObterTodos();
            
            int idp;
            while (true)
            {
                Console.WriteLine("DIGITE O ID DO PROFESSOR PARA VER SEU HORARIO: ");
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

            var professor = _rp.ObterPorId(idp);
            Console.WriteLine(professor.ToString());

            List<Turma> turmas = _rt.ListarPorParametros("Turmas", "ProfessorId", professor.Id.ToString());
            List<HoraAulaTurma> horaAulaTurmas = new List<HoraAulaTurma>();
            foreach (var t in turmas)
            {
                List<HoraAulaTurma> hat = _rhat.ListarPorParametros("HoraAulaTurmas", "TurmaId", t.Id.ToString());
                foreach (var horaAulaTurma in hat)
                {
                    horaAulaTurmas.Add(horaAulaTurma);
                }
            }

            List<Sala> salas = new List<Sala>();
            List<HoraAula> horaAulas = new List<HoraAula>();
            foreach (var hat in horaAulaTurmas)
            {
                List<Sala> s = _rs.ListarPorParametros("Salas", "Id", hat.SalaId.ToString());
                foreach (var sala in s)
                {
                    salas.Add(sala);
                }

                List<HoraAula> ha = _rha.ListarPorParametros("HoraAulas", "Id", hat.HoraAulaId.ToString());
                foreach (var horaA in ha)
                {
                    horaAulas.Add(horaA);
                }
            }

            var tabela = new ConsoleTable("X", "Inicio", "Termino", "Segunda", "Terca", "Quarta", "Quinta", "Sexta",
                "Sabado");

            string[,] mat = new string[15, 6];

            for (int i = 0; i < horaAulas.Count; i++)
            {
                int row = 0;
                int col = 0;

                switch (horaAulas[i].DiaSemana)
                {
                    case "Segunda":
                        col = 0;
                        break;
                    case "Terça":
                        col = 1;
                        break;
                    case "Quarta":
                        col = 2;
                        break;
                    case "Quinta":
                        col = 3;
                        break;
                    case "Sexta":
                        col = 4;
                        break;
                    case "Sábado":
                        col = 5;
                        break;
                }

                switch (horaAulas[i].Turno + horaAulas[i].Horario.ToString())
                {
                    case "M1":
                        row = 0;
                        break;
                    case "M2":
                        row = 1;
                        break;
                    case "M3":
                        row = 2;
                        break;
                    case "M4":
                        row = 3;
                        break;
                    case "M5":
                        row = 4;
                        break;
                    case "T1":
                        row = 5;
                        break;
                    case "T2":
                        row = 6;
                        break;
                    case "T3":
                        row = 7;
                        break;
                    case "T4":
                        row = 8;
                        break;
                    case "T5":
                        row = 9;
                        break;
                    case "N1":
                        row = 10;
                        break;
                    case "N2":
                        row = 11;
                        break;
                    case "N3":
                        row = 12;
                        break;
                    case "N4":
                        row = 13;
                        break;
                    case "N5":
                        row = 14;
                        break;
                }

                List<HoraAulaTurma> h =
                    _rhat.ListarPorParametros("HoraAulaTurmas", "HoraAulaId", horaAulas[i].Id.ToString());
                Turma t = _rt.ObterPorId((int)h[0].TurmaId);
                Materia materia = _rm.ObterPorId((int)t.MateriaId);

                mat[row, col] = materia.Nome + " - " + salas![i].Localizacao;
            }

            tabela.AddRow("M1", "07H30", "08H20", mat[0, 0], mat[0, 1], mat[0, 2], mat[0, 3], mat[0, 4], mat[0, 5]);
            tabela.AddRow("M2", "08H20", "09H10", mat[1, 0], mat[1, 1], mat[1, 2], mat[1, 3], mat[1, 4], mat[1, 5]);
            tabela.AddRow("M3", "09H10", "10H00", mat[2, 0], mat[2, 1], mat[2, 2], mat[2, 3], mat[2, 4], mat[2, 5]);
            tabela.AddRow("M4", "10H20", "11H10", mat[3, 0], mat[3, 1], mat[3, 2], mat[3, 3], mat[3, 4], mat[3, 5]);
            tabela.AddRow("M5", "11H10", "12H00", mat[4, 0], mat[4, 1], mat[4, 2], mat[4, 3], mat[4, 4], mat[4, 5]);

            tabela.AddRow("T1", "13H00", "13H50", mat[5, 0], mat[5, 1], mat[5, 2], mat[5, 3], mat[5, 4], mat[5, 5]);
            tabela.AddRow("T2", "13H50", "14H40", mat[6, 0], mat[6, 1], mat[6, 2], mat[6, 3], mat[6, 4], mat[6, 5]);
            tabela.AddRow("T3", "14H40", "15H30", mat[7, 0], mat[7, 1], mat[7, 2], mat[7, 3], mat[7, 4], mat[7, 5]);
            tabela.AddRow("T4", "15H50", "16H40", mat[8, 0], mat[8, 1], mat[8, 2], mat[8, 3], mat[8, 4], mat[8, 5]);
            tabela.AddRow("T5", "16H40", "17H30", mat[9, 0], mat[9, 1], mat[9, 2], mat[9, 3], mat[9, 4], mat[9, 5]);

            tabela.AddRow("N1", "18H40", "19H30", mat[10, 0], mat[10, 1], mat[10, 2], mat[10, 3], mat[10, 4],
                mat[10, 5]);
            tabela.AddRow("N2", "19H30", "20H20", mat[11, 0], mat[11, 1], mat[11, 2], mat[11, 3], mat[11, 4],
                mat[11, 5]);
            tabela.AddRow("N3", "20H20", "21H10", mat[12, 0], mat[12, 1], mat[12, 2], mat[12, 3], mat[12, 4],
                mat[12, 5]);
            tabela.AddRow("N4", "21H20", "22H10", mat[13, 0], mat[13, 1], mat[13, 2], mat[13, 3], mat[13, 4],
                mat[13, 5]);
            tabela.AddRow("N5", "22H10", "23H00", mat[14, 0], mat[14, 1], mat[14, 2], mat[14, 3], mat[14, 4],
                mat[14, 5]);

            tabela.Write();
        }
    }
}