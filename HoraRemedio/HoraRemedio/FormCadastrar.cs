using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HoraRemedio
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "" || tbNome.Text == "" || tbSenha.Text == "")
            {
                MessageBox.Show($"Cadastro não efetuado, por favor preencha todos os campos.");
            }
            else
            {
                var conexao = new BD();
                var valores = new Dictionary<string, object>();
                valores.Add("Usuario", tbUsuario.Text);
                valores.Add("Nome", tbNome.Text);
                valores.Add("Senha", tbSenha.Text);

                var resultado = conexao.ExecutarInsert(valores, "Clientes");

                if (resultado == "")
                {
                    MessageBox.Show($"Cadastro de {tbNome.Text} efetuado com sucesso.");
                    tbUsuario.Text = "";
                    tbNome.Text = "";
                    tbSenha.Text = "";
                }
                else if (resultado.Contains("UNIQUE"))
                {
                    MessageBox.Show("Usuário já cadastrado.");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar.");

                    FormLogin login = new FormLogin();
                    this.Hide();
                    login.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
