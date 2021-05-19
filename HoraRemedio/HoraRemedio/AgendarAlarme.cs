using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoraRemedio
{
    public class AgendarAlarme : IJob
    {
        public string Remedio { get; set; }
        public string Dias { get; set; }



        public AgendarAlarme(string remedio, string dias)
        {
            Remedio = remedio;
            Dias = dias;
        }



        public void Execute()
        {
            var now = DateTime.Now.DayOfWeek.ToString();
            if (Dias.Contains(now))
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"G:\Visual Projetos\PIT\Arquivos\Alarme.wav";
                player.PlayLooping();
                MessageBox.Show($"Hora do Remédio: \n {Remedio}");
            }
        }
    }
}
