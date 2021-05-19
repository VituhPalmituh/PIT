using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraRemedio
{
    public class AgendamentoTarefas : Registry
    {
        public AgendamentoTarefas(int hora, int minuto, string remedio, string dias)
        {
            Schedule(new AgendarAlarme(remedio, dias)).NonReentrant().ToRunOnceAt(hora, minuto).AndEvery(1).Days();
        }
    }
}
