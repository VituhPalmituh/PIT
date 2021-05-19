using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace HoraRemedio
{
    public partial class FormMenu : Form
    {
        private int idCliente;
        private SoundPlayer somalarme;

        public int IdCliente { get => idCliente; set => idCliente = value; }

        public FormMenu()
        {
            InitializeComponent();
            somalarme = new SoundPlayer("MahnaMahna.mp3");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ShowIcon = false;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000);
            base.OnFormClosing(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAgenda agenda = new FormAgenda();
            agenda.IdCliente = IdCliente;
            this.Hide();
            agenda.ShowDialog();
            this.Close();
        }

        private void alarme_Click(object sender, EventArgs e)
        {
            FormAlarme alarme = new FormAlarme();
            alarme.IdCliente = IdCliente;
            this.Hide();
            alarme.ShowDialog();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }



        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
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

        private void lbAlarme_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowIcon = false;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void FormMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowIcon = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }
    }
}
