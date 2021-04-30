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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAgenda agenda = new FormAgenda();
            this.Hide();
            agenda.ShowDialog();
            this.Close();
        }

        private void alarme_Click(object sender, EventArgs e)
        {
            FormAlarme alarme = new FormAlarme();
            this.Hide();
            alarme.ShowDialog();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void lbRelogio_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbRelogio.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
