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
        private int idCliente;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public FormAgenda()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.IdCliente = IdCliente;
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void btnSalvarDia_Click(object sender, EventArgs e)
        {
            if (tbDescricao.Text == "")
            {
                MessageBox.Show("Erro ao agendar o dia.");
            }
            else
            {
                var conexao = new BD();
                var valores = new Dictionary<string, object>();
                valores.Add("IdCliente", IdCliente);
                valores.Add("Dia", numDia.Value);
                valores.Add("Mes", numMes.Value);
                valores.Add("Ano", numAno.Value);
                valores.Add("Hora", numHora.Value);
                valores.Add("Minuto", numMinuto.Value);
                valores.Add("Descricao", tbDescricao.Text);

                var resultado = conexao.ExecutarInsert(valores, "Agendas");

                if (resultado == "")
                {
                    int contadorAgenda = clbAgenda.Items.Count + 1;
                    clbAgenda.Items.Add($"Agenda {contadorAgenda} - {numDia.Value}/{numMes.Value}/{numAno.Value} - {numHora.Value}:{numMinuto.Value} - {tbDescricao.Text}");
                    MessageBox.Show("Agenda adicionado.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conexao = new BD();

            int alarmeCount = clbAgenda.CheckedItems.Count;

            for (int i = 0; i < alarmeCount; i++)
            {
                var checkedItem = clbAgenda.CheckedItems[0];
                var idAgenda = Convert.ToInt32(checkedItem.ToString().Split('-')[0].Replace("Agenda", ""));
                string deleteAgenda = $"IdAgenda = {idAgenda}";

                string resultado = conexao.ExecutarExcluir("Agendas", deleteAgenda);
                if (resultado == "")
                {
                    clbAgenda.Items.Remove(checkedItem);
                    MessageBox.Show("Agenda removida.");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao tentar remover a agenda.");
                }
            }
        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            var conexao = new BD();
            string selectAgendas = $"SELECT * FROM Agendas WHERE IdCliente = {IdCliente}";
            var resultado = conexao.ExecutarSelect(selectAgendas);

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clbAgenda.Items.Add($"Agenda {i} - {Convert.ToInt32(resultado.Rows[i]["Dia"])}/{Convert.ToInt32(resultado.Rows[i]["Mes"])}/{Convert.ToInt32(resultado.Rows[i]["Ano"])} - {Convert.ToInt32(resultado.Rows[i]["Hora"])}:{Convert.ToInt32(resultado.Rows[i]["Minuto"])} - {resultado.Rows[i]["Descricao"]}");
            }
        }

        private void clbAgenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
