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
        private static readonly SCursoMateria _scm = new SCursoMateria();
        private static readonly SAlunoTurma _sat = new SAlunoTurma();
        private static readonly SHoraAulaTurmas _shat = new SHoraAulaTurmas();

        public static void Main()
        {
            int sair = 0;

            while (sair != 1)
            {
                int brk = 0;

                switch (Menu.MenuPadrao())
                {
                    case 1: // Aluno
                        while (brk != 1)
                        {
                            switch (Menu.MenuAluno())
                            {
                                case 1:
                                    Console.Clear();
                                    _sa.Inserir();
                                    break;
                                case 2:
                                    Console.Clear();
                                    _sa.Atualizar();
                                    break;
                                case 3:
                                    Console.Clear();
                                    _sa.Excluir();
                                    break;
                                case 4:
                                    Console.Clear();
                                    _sa.ObterPorId();
                                    break;
                                case 5:
                                    Console.Clear();
                                    _sa.ObterTodos();
                                    break;
                                case 6:// Horario
                                    Console.Clear();
                                    _sat.VerHorarioAluno();
                                    break;
                                case 7: //Boletim
                                    Console.Clear();
                                    _sat.GerarBoletim();
                                    break;
                                default:
                                    Console.Clear();
                                    brk = 1;
                                    break;
                            }
                        }

                        break;
                    case 2: // Professor
                        while (brk != 1)
                        {
                            switch (Menu.MenuProfessor())
                            {
                                case 1:
                                    Console.Clear();
                                    _sp.Inserir();
                                    break;
                                case 2:
                                    Console.Clear();
                                    _sp.Atualizar();
                                    break;
                                case 3:
                                    Console.Clear();
                                    _sp.Excluir();
                                    break;
                                case 4:
                                    Console.Clear();
                                    _sp.ObterPorId();
                                    break;
                                case 5:
                                    Console.Clear();
                                    _sp.ObterTodos();
                                    break;
                                case 6:
                                    Console.Clear();
                                    _sp.VerHorarioProfessor();
                                    break;
                                default:
                                    Console.Clear();
                                    brk = 1;
                                    break;
                            }
                        }

                        break;
                    case 3: // Hora Aula
                        while (brk != 1)
                        {
                            switch (Menu.MenuHoraAula())
                            {
                                case 1:
                                    Console.Clear();
                                    _sha.Inserir();
                                    break;
                                case 2:
                                    Console.Clear();
                                    _sha.Atualizar();
                                    break;
                                case 3:
                                    Console.Clear();
                                    _sha.Excluir();
                                    break;
                                case 4:
                                    Console.Clear();
                                    _sha.ObterPorId();
                                    break;
                                case 5:
                                    Console.Clear();
                                    _sha.ObterTodos();
                                    break;
                                default:
                                    Console.Clear();
                                    brk = 1;
                                    break;
                            }
                        }

                        break;
                    case 4: // Materia
                        while (brk != 1)
                        {
                            switch (Menu.MenuMateria())
                            {
                                case 1:
                                    Console.Clear();
                                    _sm.Inserir();
                                    break;
                                case 2:
                                    Console.Clear();
                                    _sm.Atualizar();
                                    break;
                                case 3:
                                    Console.Clear();
                                    _sm.Excluir();
                                    break;
                                case 4:
                                    Console.Clear();
                                    _sm.ObterPorId();
                                    break;
                                case 5:
                                    Console.Clear();
                                    _sm.ObterTodos();
                                    break;
                                default:
                                    Console.Clear();
                                    brk = 1;
                                    break;
                            }
                        }

                        break;
                    case 5: // Sala
                        while (brk != 1)
                        {
                            switch (Menu.MenuSala())
                            {
                                case 1:
                                    Console.Clear();
                                    _ss.Inserir();
                                    break;
                                case 2:
                                    Console.Clear();
                                    _ss.Atualizar();
                                    break;
                                case 3:
                                    Console.Clear();
                                    _ss.Excluir();
                                    break;
                                case 4:
                                    Console.Clear();
                                    _ss.ObterPorId();
                                    break;
                                case 5:
                                    Console.Clear();
                                    _ss.ObterTodos();
                                    break;
                                default:
                                    Console.Clear();
                                    brk = 1;
                                    break;
                            }
                        }

                        break;
                    case 6: // Turma
                        while (brk != 1)
                        {
                            switch (Menu.MenuTurma())
                            {
                                case 1:
                                    Console.Clear();
                                    _st.Inserir();
                                    break;
                                case 2:
                                    Console.Clear();
                                    _st.Atualizar();
                                    break;
                                case 3:
                                    Console.Clear();
                                    _st.Excluir();
                                    break;
                                case 4:
                                    Console.Clear();
                                    _st.ObterPorId();
                                    break;
                                case 5:
                                    Console.Clear();
                                    _st.ObterTodos();
                                    break;
                                default:
                                    Console.Clear();
                                    brk = 1;
                                    break;
                            }
                        }

                        break;
                    case 7: // Curso
                        while (brk != 1)
                        {
                            switch (Menu.MenuCurso())
                            {
                                case 1:
                                    Console.Clear();
                                    _sc.Inserir();
                                    break;
                                case 2:
                                    Console.Clear();
                                    _sc.Atualizar();
                                    break;
                                case 3:
                                    Console.Clear();
                                    _sc.Excluir();
                                    break;
                                case 4:
                                    Console.Clear();
                                    _sc.ObterPorId();
                                    break;
                                case 5:
                                    Console.Clear();
                                    _sc.ObterTodos();
                                    break;
                                case 6:
                                    Console.Clear();
                                    _scm.VerMatrizCurricular();
                                    break;
                                default:
                                    Console.Clear();
                                    brk = 1;
                                    break;
                            }
                        }

                        break;
                    case 8:
                        while (brk != 1)
                        {
                            switch (Menu.MenuMatricula())
                            {
                                case 1:
                                    Console.Clear();
                                    _sat.Inserir();
                                    break;
                                case 2:
                                    Console.Clear();
                                    _sat.Atualizar();
                                    break;
                                case 3:
                                    Console.Clear();
                                    _sat.Excluir();
                                    break;
                                case 4:
                                    Console.Clear();
                                    _sat.ObterPorIds();
                                    break;
                                case 5:
                                    Console.Clear();
                                    _sat.ObterTodosAlunosTurmas();
                                    break;
                                case 6:
                                    Console.Clear();
                                    _sat.ObterTodosTurmasAlunos();
                                    break;
                                default:
                                    Console.Clear();
                                    brk = 1;
                                    break;
                            }
                        }

                        break;
                    case 9:
                        while (brk != 1)
                        {
                            switch (Menu.MenuHorarios())
                            {
                                case 1:
                                    Console.Clear();
                                    _shat.Inserir();
                                    break;
                                case 2:
                                    Console.Clear();
                                    _shat.Atualizar();
                                    break;
                                case 3:
                                    Console.Clear();
                                    _sat.Excluir();
                                    break;
                                case 4:
                                    Console.Clear();
                                    _shat.ObterPorIds();
                                    break;
                                case 5:
                                    Console.Clear();
                                    _shat.ObterTodosHoraAulaTurmas();
                                    break;
                                case 6:
                                    Console.Clear();
                                    _shat.ObterTodosTurmasHoraAula();
                                    break;
                                default:
                                    Console.Clear();
                                    brk = 1;
                                    break;
                            }
                        }

                        break;
                    case 10:
                        while (brk != 1)
                        {
                            switch (Menu.MenuMatriz())
                            {
                                case 1:
                                    Console.Clear();
                                    _scm.Inserir();
                                    break;
                                case 2:
                                    Console.Clear();
                                    _scm.Atualizar();
                                    break;
                                case 3:
                                    Console.Clear();
                                    _scm.Excluir();
                                    break;
                                case 4:
                                    Console.Clear();
                                    _scm.ObterPorIds();
                                    break;
                                case 5:
                                    Console.Clear();
                                    _scm.ObterTodosCursosMateria();
                                    break;
                                case 6:
                                    Console.Clear();
                                    _scm.ObterTodosMateriasCurso();
                                    break;
                                default:
                                    Console.Clear();
                                    brk = 1;
                                    break;
                            }
                        }

                        break;
                    default:
                        Console.Clear();
                        sair = 1;
                        break;
                }
            }
        }
    }
}
