using GerenciamentoEscola.Services;
using System;

namespace GerenciamentoEscola
{
    public static class Program
    {
        private static readonly SSala _ss = new SSala();
        private static readonly SAluno _sa = new SAluno();
        private static readonly SProfessor _sp = new SProfessor();
        private static readonly SHoraAula _sha = new SHoraAula();
        private static readonly STurma _st = new STurma();
        private static readonly SCurso _sc = new SCurso();
        private static readonly SMateria _sm = new SMateria();

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
                    case 2: // Professor
                        while (brk != 1)
                        {
                            switch (MenuProfessor())
                            {
                                case 1:
                                    _sp.Inserir();
                                    break;
                                case 2:
                                    _sp.Atualizar();
                                    break;
                                case 3:
                                    _sp.Excluir();
                                    break;
                                case 4:
                                    _sp.ObterPorId();
                                    break;
                                case 5:
                                    _sp.ObterTodos();
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
                                    _sha.Inserir();
                                    break;
                                case 2:
                                    _sha.Atualizar();
                                    break;
                                case 3:
                                    _sha.Excluir();
                                    break;
                                case 4:
                                    _sha.ObterPorId();
                                    break;
                                case 5:
                                    _sha.ObterTodos();
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
                                    _sm.Inserir();
                                    break;
                                case 2:
                                    _sm.Atualizar();
                                    break;
                                case 3:
                                    _sm.Excluir();
                                    break;
                                case 4:
                                    _sm.ObterPorId();
                                    break;
                                case 5:
                                    _sm.ObterTodos();
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
                                    _ss.Inserir();
                                    break;
                                case 2:
                                    _ss.Atualizar();
                                    break;
                                case 3:
                                    _ss.Excluir();
                                    break;
                                case 4:
                                    _ss.ObterPorId();
                                    break;
                                case 5:
                                    _ss.ObterTodos();
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
                                    _st.Inserir();
                                    break;
                                case 2:
                                    _st.Atualizar();
                                    break;
                                case 3:
                                    _st.Excluir();
                                    break;
                                case 4:
                                    _st.ObterPorId();
                                    break;
                                case 5:
                                    _st.ObterTodos();
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
                                    _sc.Inserir();
                                    break;
                                case 2:
                                    _sc.Atualizar();
                                    break;
                                case 3:
                                    _sc.Excluir();
                                    break;
                                case 4:
                                    _sc.ObterPorId();
                                    break;
                                case 5:
                                    _sc.ObterTodos();
                                    break;
                                case 6: // Inserir materia ao curso
                                    //_sc.Listar
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

        public static int MenuAluno()
        {
            int option;

            while (true)
            {
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

        public static int MenuProfessor()
        {
            int option;

            while (true)
            {
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

        public static int MenuHoraAula()
        {
            int option;

            while (true)
            {
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

        public static int MenuTurma()
        {
            int option;

            while (true)
            {
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
    }
}
