using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoraRemedio
{
    public partial class FormAgenda : Form
    {
        public FormAgenda()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void btnSalvarDia_Click(object sender, EventArgs e)
        {
            int contadorDia = clbAgenda.Items.Count + 1;
            clbAgenda.Items.Add($"Agenda {contadorDia} - {numericUpDown1.Value}/{numericUpDown2.Value}/{numericUpDown3.Value} - " +
                $"{numericUpDown4.Value}:{numericUpDown5.Value} - {textBox1.Text}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int agendaCount = clbAgenda.CheckedItems.Count;

            for (int i = 0; i < agendaCount; i++)
            {
                clbAgenda.Items.Remove(clbAgenda.CheckedItems[0]);
            }
        }
    }
}
