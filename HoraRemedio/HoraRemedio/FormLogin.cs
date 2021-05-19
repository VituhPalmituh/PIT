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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void botaoConectar_Click(object sender, EventArgs e)
        {
            var conexao = new BD();
            string selectLogin = $"SELECT * FROM Clientes WHERE Usuario = '{tbUsuario.Text}' AND Senha = '{tbSenha.Text}'";
            var resultado = conexao.ExecutarSelect(selectLogin);
            if (resultado != null && resultado.Rows.Count > 0)
            {
                MessageBox.Show("Login efetuado com sucesso.");
                FormMenu menu = new FormMenu();
                menu.IdCliente = Convert.ToInt32(resultado.Rows[0]["IdCliente"]);
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorretos.");
            }
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrar cadastrar = new FormCadastrar();
            this.Hide();
            cadastrar.ShowDialog();
            this.Close();
        }

        private void lbSenha_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
