using GerenciamentoEscola.Services;

namespace GerenciamentoEscola;

public static class Program
{
    private static readonly SSala _sa = new SSala();
    public static void Main()
    {

        int sair = 0;

        while (sair != 1)
        {
            int brk = 0;
            
            switch (Menu())
            {
                case 1: // Aluno
                    while (brk != 1)
                    {
                        switch (MenuAluno())
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                            case 6:
                                break;
                            default:
                                brk = 1;
                                break;
                        }
                    }
                    
                    break;
                case 2: // Professor
                    while (brk != 1)
                    {
                        switch (MenuProfessor())
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                            case 6:
                                break;
                            default:
                                brk = 1;
                                break;
                        }
                    }

                    break;
                case 3: // Hora Aula
                    while (brk != 1)
                    {
                        switch (MenuHoraAula())
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                            case 6:
                                break;
                            default:
                                brk = 1;
                                break;
                        }
                    }
                    
                    break;
                case 4: // Materia
                    while (brk != 1)
                    {
                        switch (MenuMateria())
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                            case 6:
                                break;
                            default:
                                brk = 1;
                                break;
                        }
                    }
                    
                    break;
                case 5: // Sala
                    while (brk != 1)
                    {
                        switch (MenuSala())
                        {
                            case 1:
                                _sa.Inserir();
                                break;
                            case 2:
                                _sa.Atualizar();
                                break;
                            case 3:
                                _sa.Excluir();
                                break;
                            case 4:
                                _sa.ObterPorId();
                                break;
                            case 5:
                                _sa.ObterTodos();
                                break;
                            default:
                                brk = 1;
                                break;
                        }
                    }
                    
                    break;
                case 6: // Turma
                    while (brk != 1)
                    {
                        switch (MenuTurma())
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                            case 6:
                                break;
                            default:
                                brk = 1;
                                break;
                        }
                    }
                    
                    break;
                case 7: // Curso
                    while (brk != 1)
                    {
                        switch (MenuCurso())
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                            case 6:
                                break;
                            default:
                                brk = 1;
                                break;
                        }
                    }
                    
                    break;
                default:
                    sair = 1;
                    break;
            }
        }
    }

    public static int Menu()
    {
        Console.WriteLine("-=: Digite a opção desejada :=-");
        Console.WriteLine("1 - Aluno");
        Console.WriteLine("2 - Professor");
        Console.WriteLine("3 - Hora Aula");
        Console.WriteLine("4 - Materia");
        Console.WriteLine("5 - Sala");
        Console.WriteLine("6 - Turma");
        Console.WriteLine("7 - Curso");
        Console.WriteLine("0 - Sair");
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int MenuAluno()
    {
        Console.WriteLine("-=: Digite a opção desejada :=-");
        Console.WriteLine("1 - Adicionar");
        Console.WriteLine("2 - Atualizar");
        Console.WriteLine("3 - Excluir");
        Console.WriteLine("4 - Obter Por ID");
        Console.WriteLine("5 - Obter Todos");
        return Convert.ToInt32(Console.ReadLine());
    }
    
    public static int MenuProfessor()
    {
        Console.WriteLine("-=: Digite a opção desejada :=-");
        Console.WriteLine("1 - Adicionar");
        Console.WriteLine("2 - Atualizar");
        Console.WriteLine("3 - Excluir");
        Console.WriteLine("4 - Obter Por ID");
        Console.WriteLine("5 - Obter Todos");
        return Convert.ToInt32(Console.ReadLine());
    }
    
    public static int MenuHoraAula()
    {
        Console.WriteLine("-=: Digite a opção desejada :=-");
        Console.WriteLine("1 - Adicionar");
        Console.WriteLine("2 - Atualizar");
        Console.WriteLine("3 - Excluir");
        Console.WriteLine("4 - Obter Por ID");
        Console.WriteLine("5 - Obter Todos");
        return Convert.ToInt32(Console.ReadLine());
    }
    
    public static int MenuMateria()
    {
        Console.WriteLine("-=: Digite a opção desejada :=-");
        Console.WriteLine("1 - Adicionar");
        Console.WriteLine("2 - Atualizar");
        Console.WriteLine("3 - Excluir");
        Console.WriteLine("4 - Obter Por ID");
        Console.WriteLine("5 - Obter Todos");
        return Convert.ToInt32(Console.ReadLine());
    }
    
    public static int MenuSala()
    {
        Console.WriteLine("-=: Digite a opção desejada :=-");
        Console.WriteLine("1 - Adicionar");
        Console.WriteLine("2 - Atualizar");
        Console.WriteLine("3 - Excluir");
        Console.WriteLine("4 - Obter Por ID");
        Console.WriteLine("5 - Obter Todos");
        return Convert.ToInt32(Console.ReadLine());
    }
    
    public static int MenuTurma()
    {
        Console.WriteLine("-=: Digite a opção desejada :=-");
        Console.WriteLine("1 - Adicionar");
        Console.WriteLine("2 - Atualizar");
        Console.WriteLine("3 - Excluir");
        Console.WriteLine("4 - Obter Por ID");
        Console.WriteLine("5 - Obter Todos");
        return Convert.ToInt32(Console.ReadLine());
    }
    
    public static int MenuCurso()
    {
        Console.WriteLine("-=: Digite a opção desejada :=-");
        Console.WriteLine("1 - Adicionar");
        Console.WriteLine("2 - Atualizar");
        Console.WriteLine("3 - Excluir");
        Console.WriteLine("4 - Obter Por ID");
        Console.WriteLine("5 - Obter Todos");
        return Convert.ToInt32(Console.ReadLine());
    }
}