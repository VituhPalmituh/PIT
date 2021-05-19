using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HoraRemedio
{
    class BD
    {
        private static SqlConnection conexao = new SqlConnection();
        private static SqlCommand comando = new SqlCommand();
        public BD()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Pit;Integrated Security=True";
            comando = conexao.CreateCommand();
            conexao.Open();
        }

        public string ExecutarInsert(Dictionary<string, object> valores, string tabela)
        {
            string retorno = "";
            string cmdInserir = "INSERT INTO " + tabela + "(";
            foreach (var item in valores)
            {
                cmdInserir += item.Key + ",";
            }

            cmdInserir = cmdInserir.Remove(cmdInserir.Length - 1);
            cmdInserir += ") VALUES(";

            foreach (var item in valores)
            {
                cmdInserir += "@" + item.Key + ",";
            }

            cmdInserir = cmdInserir.Remove(cmdInserir.Length - 1);
            cmdInserir += ")";

            comando.CommandText = cmdInserir;
            comando.Parameters.Clear();

            foreach (var item in valores)
            {
                comando.Parameters.AddWithValue("@" + item.Key, item.Value);
            }

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                retorno = "Falha ao inserir dados\n" + ex.Message;
            }
            finally
            {
                conexao.Close();
            }

            return retorno;
        }

        public DataTable ExecutarSelect(string pComandoSelect)
        {
            DataTable tabela = new DataTable();
            comando.CommandText = pComandoSelect;

            try
            {
                tabela.Load(comando.ExecuteReader());
            }
            catch (Exception ex)
            {
                tabela = null;
            }

            return tabela;
        }

        public string ExecutarExcluir(string pTabela, string pCondicao)
        {
            string retorno;
            string cmdExcluir = "DELETE FROM " + pTabela + " WHERE " + pCondicao;
            retorno = "";
            comando.CommandText = cmdExcluir;

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                retorno = "Falha ao excluir os dados.\n" + ex.Message;
            }
            return retorno;
        }
    }
}
