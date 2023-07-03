namespace GerenciamentoEscola;

public class Menu
{
    public static int MenuPadrao()
        {
            int option;

            while (true)
            {
                Console.WriteLine("-=: Digite a opção desejada :=-");
                Console.WriteLine("1 - Aluno");
                Console.WriteLine("2 - Professor");
                Console.WriteLine("3 - Hora Aula");
                Console.WriteLine("4 - Materia");
                Console.WriteLine("5 - Sala");
                Console.WriteLine("6 - Turma");
                Console.WriteLine("7 - Curso");
                Console.WriteLine("8 - Matricula");
                Console.WriteLine("9 - Horarios");
                Console.WriteLine("10 - Matriz Curricular");
                Console.WriteLine("0 - Sair");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    if (option >= 0 && option <= 10)
                        break;
                }

                Console.WriteLine("Opção inválida. Digite um número válido:");
            }

            return option;
        }

        public static int MenuAluno()
        {
            int option;

            while (true)
            {
                Console.WriteLine("-=: ALUNO :=-");
                Console.WriteLine("-=: Digite a opção desejada :=-");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Atualizar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Obter Por ID");
                Console.WriteLine("5 - Obter Todos");
                Console.WriteLine("6 - Ver Horario Aluno");
                Console.WriteLine("7 - Gerar Boletim");
                Console.WriteLine("0 - Sair");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    if (option >= 0 && option <= 7)
                        break;
                }

                Console.WriteLine("Opção inválida. Digite um número válido:");
            }

            return option;
        }

        public static int MenuProfessor()
        {
            int option;

            while (true)
            {
                Console.WriteLine("-=: PROFESSOR :=-");
                Console.WriteLine("-=: Digite a opção desejada :=-");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Atualizar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Obter Por ID");
                Console.WriteLine("5 - Obter Todos");
                Console.WriteLine("6 - Ver Mapa do Professor");
                Console.WriteLine("0 - Sair");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    if (option >= 0 && option <= 6)
                        break;
                }

                Console.WriteLine("Opção inválida. Digite um número válido:");
            }

            return option;
        }

        public static int MenuHoraAula()
        {
            int option;

            while (true)
            {
                Console.WriteLine("-=: HORA AULA :=-");
                Console.WriteLine("-=: Digite a opção desejada :=-");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Atualizar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Obter Por ID");
                Console.WriteLine("5 - Obter Todos");
                Console.WriteLine("0 - Sair");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    if (option >= 0 && option <= 5)
                        break;
                }

                Console.WriteLine("Opção inválida. Digite um número válido:");
            }

            return option;
        }

        public static int MenuMateria()
        {
            int option;

            while (true)
            {
                Console.WriteLine("-=: MATERIA :=-");
                Console.WriteLine("-=: Digite a opção desejada :=-");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Atualizar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Obter Por ID");
                Console.WriteLine("5 - Obter Todos");
                Console.WriteLine("0 - Sair");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    if (option >= 0 && option <= 5)
                        break;
                }

                Console.WriteLine("Opção inválida. Digite um número válido:");
            }

            return option;
        }

        public static int MenuSala()
        {
            int option;

            while (true)
            {
                Console.WriteLine("-=: SALA :=-");
                Console.WriteLine("-=: Digite a opção desejada :=-");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Atualizar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Obter Por ID");
                Console.WriteLine("5 - Obter Todos");
                Console.WriteLine("0 - Sair");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    if (option >= 0 && option <= 5)
                        break;
                }

                Console.WriteLine("Opção inválida. Digite um número válido:");
            }

            return option;
        }

        public static int MenuMatricula()
        {
            int option;

            while (true)
            {
                Console.WriteLine("-=: MATRICULA :=-");
                Console.WriteLine("-=: Digite a opção desejada :=-");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Atualizar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Obter Por ID");
                Console.WriteLine("5 - Obter Todos Os Alunos Da Turma");
                Console.WriteLine("6 - Obter Todos As Turmas Do Aluno");
                Console.WriteLine("0 - Sair");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    if (option >= 0 && option <= 6)
                        break;
                }

                Console.WriteLine("Opção inválida. Digite um número válido:");
            }

            return option;
        }
        
        public static int MenuHorarios()
        {
            int option;

            while (true)
            {
                Console.WriteLine("-=: HORÁRIOS :=-");
                Console.WriteLine("-=: Digite a opção desejada :=-");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Atualizar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Obter Por ID");
                Console.WriteLine("5 - Obter Todos As Horas Aula Da Turma");
                Console.WriteLine("6 - Obter Todos As Turmas Da Hora Aula");
                Console.WriteLine("0 - Sair");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    if (option >= 0 && option <= 6)
                        break;
                }

                Console.WriteLine("Opção inválida. Digite um número válido:");
            }

            return option;
        }
        
        public static int MenuMatriz()
                {
                    int option;
        
                    while (true)
                    {
                        Console.WriteLine("-=: MATRIZ CURRICULAR :=-");
                        Console.WriteLine("-=: Digite a opção desejada :=-");
                        Console.WriteLine("1 - Adicionar");
                        Console.WriteLine("2 - Atualizar");
                        Console.WriteLine("3 - Excluir");
                        Console.WriteLine("4 - Obter Por ID");
                        Console.WriteLine("5 - Obter Todos Os Cursos Que Fazem Uma Materia");
                        Console.WriteLine("6 - Obter Todos As Materias Do Curso");
                        Console.WriteLine("0 - Sair");
        
                        if (int.TryParse(Console.ReadLine(), out option))
                        {
                            if (option >= 0 && option <= 6)
                                break;
                        }
        
                        Console.WriteLine("Opção inválida. Digite um número válido:");
                    }
        
                    return option;
                }

        public static int MenuTurma()
        {
            int option;

            while (true)
            {
                Console.WriteLine("-=: TURMA :=-");
                Console.WriteLine("-=: Digite a opção desejada :=-");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Atualizar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Obter Por ID");
                Console.WriteLine("5 - Obter Todos");
                Console.WriteLine("0 - Sair");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    if (option >= 0 && option <= 5)
                        break;
                }

                Console.WriteLine("Opção inválida. Digite um número válido:");
            }

            return option;
        }

        public static int MenuCurso()
        {
            int option;

            while (true)
            {
                Console.WriteLine("-=: CURSO :=-");
                Console.WriteLine("-=: Digite a opção desejada :=-");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Atualizar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Obter Por ID");
                Console.WriteLine("5 - Obter Todos");
                Console.WriteLine("6 - Ver Matriz Curricular");
                Console.WriteLine("0 - Sair");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    if (option >= 0 && option <= 6)
                        break;
                }

                Console.WriteLine("Opção inválida. Digite um número válido:");
            }

            return option;
        }
    
}