using FluentScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoraRemedio
{
    public partial class FormAlarme : Form
    {
        private int idCliente;

        public int IdCliente { get => idCliente; set => idCliente = value; }

        public FormAlarme()
        {
            InitializeComponent();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.IdCliente = IdCliente;
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dias = diasSelecionados();

            if (tbRemedio.Text == "")
            {
                MessageBox.Show("Erro ao adicionar o alarme.");
            }
            else
            {
                var conexao = new BD();
                var valores = new Dictionary<string, object>();
                valores.Add("IdCliente", IdCliente);
                valores.Add("Hora", numHora.Value);
                valores.Add("Minuto", numMinuto.Value);
                valores.Add("Remedio", tbRemedio.Text);
                valores.Add("Semana", dias);

                var resultado = conexao.ExecutarInsert(valores, "Alarmes");

                if (resultado == "")
                {
                    int contadorAlarme = clbAlarme.Items.Count + 1;
                    clbAlarme.Items.Add($"Alarme {contadorAlarme} - {tbRemedio.Text} - {numHora.Value}:{numMinuto.Value} - {dias}");
                    MessageBox.Show("Alarme adicionado.");

                    JobManager.Initialize(new AgendamentoTarefas(Convert.ToInt32(numHora.Value), Convert.ToInt32(numMinuto.Value), tbRemedio.Text, dias));
                }
            }
        }

        private void FormAlarme_Load(object sender, EventArgs e)
        {
            var conexao = new BD();
            string selectAlarmes = $"SELECT * FROM Alarmes WHERE IdCliente = {IdCliente}";
            var resultado = conexao.ExecutarSelect(selectAlarmes);

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clbAlarme.Items.Add($"Alarme {Convert.ToInt32(resultado.Rows[i]["IdAlarme"])} - {resultado.Rows[i]["Remedio"]} - {Convert.ToInt32(resultado.Rows[i]["Hora"])} - {Convert.ToInt32(resultado.Rows[i]["Minuto"])} - {resultado.Rows[i]["Semana"]}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var conexao = new BD();

            int alarmeCount = clbAlarme.CheckedItems.Count;

            for (int i = 0; i < alarmeCount; i++)
            {
                var checkedItem = clbAlarme.CheckedItems[0];
                var idAlarme = Convert.ToInt32(checkedItem.ToString().Split('-')[0].Replace("Alarme", ""));
                string deleteAlarme = $"IdAlarme = {idAlarme}";

                string resultado = conexao.ExecutarExcluir("Alarmes", deleteAlarme);
                if (resultado == "")
                {
                    clbAlarme.Items.Remove(checkedItem);
                    MessageBox.Show("Alarme removido.");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao tentar remover o alarme.");
                }
            }
        }

        private string diasSelecionados()
        {
            List<string> dias = new List<string>();
            string diasCheck = "";

            if (cbSeg.Checked)
            {
                dias.Add("Monday");
            }
            if (cbTer.Checked)
            {
                dias.Add("Tuesday");
            }
            if (cbQua.Checked)
            {
                dias.Add("Wednesday");
            }
            if (cbQui.Checked)
            {
                dias.Add("Thursday");
            }
            if (cbSex.Checked)
            {
                dias.Add("Friday");
            }
            if (cbSab.Checked)
            {
                dias.Add("Saturday");
            }
            if (cbDom.Checked)
            {
                dias.Add("Sunday");
            }

            foreach (var item in dias)
            {
                if (item.ToString() != "Dom")
                {
                    diasCheck += item.ToString() + "/";
                }
            }

            return diasCheck;
        }

        private void clbAlarme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
