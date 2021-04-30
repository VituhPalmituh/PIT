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
    public partial class FormAlarme : Form
    {
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
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int contadorAlarme = clbAlarme.Items.Count + 1;
            string dias = "";

            clbAlarme.Items.Add($"Alarme {contadorAlarme} - {textBox1.Text} - {numHora.Value}:{numMinuto.Value} - {diasSelecionados()}");
        }

        private void FormAlarme_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int alarmeCount = clbAlarme.CheckedItems.Count;

            for (int i = 0; i < alarmeCount; i++)
            {
                clbAlarme.Items.Remove(clbAlarme.CheckedItems[0]);
            }
        }

        private string diasSelecionados()
        {
            List<string> dias = new List<string>();
            string diasCheck = "";

            if (cbSeg.Checked)
            {
                dias.Add("Seg");
            }
            if (cbTer.Checked)
            {
                dias.Add("Ter");
            }
            if (cbQua.Checked)
            {
                dias.Add("Qua");
            }
            if (cbQui.Checked)
            {
                dias.Add("Qui");
            }
            if (cbSex.Checked)
            {
                dias.Add("Sex");
            }
            if (cbSab.Checked)
            {
                dias.Add("Sab");
            }
            if (cbDom.Checked)
            {
                dias.Add("Dom");
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
