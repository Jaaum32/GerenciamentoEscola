using System.ComponentModel.DataAnnotations;

namespace GerenciamentoEscola.Model;

public class HoraAula
{
    public override string ToString()
    {
        return "Id: " + Id +
               "\nDia da Semana: " + DiaSemana +
               "\nTurno: " + Turno +
               "\nHorario: " + Horario +
               "\nHora de Inicio: " + HoraInicio +
               "\nHora de Fim: " + HoraFim;
    }

    public HoraAula()
    {
    }

    public HoraAula(int? id, string diaSemana, char turno, int horario)
    {
        Id = id;
        DiaSemana = diaSemana;
        Turno = turno;
        Horario = horario;

        switch (Turno)
        {
            case 'M':
                switch (Horario)
                {
                    case 1:
                        HoraInicio = "07H30";
                        HoraFim = "08H20";
                        break;
                    case 2:
                        HoraInicio = "08H20";
                        HoraFim = "09H10";
                        break;
                    case 3:
                        HoraInicio = "09H10";
                        HoraFim = "10H00";
                        break;
                    case 4:
                        HoraInicio = "10H20";
                        HoraFim = "11H10";
                        break;
                    case 5:
                        HoraInicio = "11H10";
                        HoraFim = "12H00";
                        break;
                    default:
                        break;
                }
                break;
            case 'T':
                switch (Horario)
                {
                    case 1:
                        HoraInicio = "13H00";
                        HoraFim = "13H50";
                        break;
                    case 2:
                        HoraInicio = "13H50";
                        HoraFim = "14H40";
                        break;
                    case 3:
                        HoraInicio = "14H40";
                        HoraFim = "15H30";
                        break;
                    case 4:
                        HoraInicio = "15H50";
                        HoraFim = "16H40";
                        break;
                    case 5:
                        HoraInicio = "16H40";
                        HoraFim = "17H30";
                        break;
                    default:
                        break;
                }
                break;
            case 'N':
                switch (Horario)
                {
                    case 1:
                        HoraInicio = "18H40";
                        HoraFim = "19H30";
                        break;
                    case 2:
                        HoraInicio = "19H30";
                        HoraFim = "20H20";
                        break;
                    case 3:
                        HoraInicio = "20H20";
                        HoraFim = "21H10";
                        break;
                    case 4:
                        HoraInicio = "21H20";
                        HoraFim = "22H10";
                        break;
                    case 5:
                        HoraInicio = "22H10";
                        HoraFim = "23H00";
                        break;
                    default:
                        break;
                }
                break;
            default:
                break;
        }
    }

    [Key]
    public int? Id { get; set; }
    
    public string DiaSemana { get; set; }
    public char Turno { get; set; }
    public int Horario { get; set; }
    public string HoraInicio { get; set; }
    public string HoraFim { get; set; }
    
    public IEnumerable<HoraAulaTurma>? Turmas { get; set; }
}