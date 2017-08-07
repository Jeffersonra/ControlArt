using MySql.Data.MySqlClient;
using System.Data;

namespace ControlArt.ClassDB
{
    class Conecta
    {

        // atributos //
        private string string_conexao = "Persist Security Info=False; server=;database=;Uid=; Pwd=";
        public string query_string = "";

        #region metodos

        // metodos //
        public MySqlDataReader mysql_data_reader()
        {
            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = this.string_conexao;
            conexao.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = query_string;
            comando.Connection = conexao;

            MySqlDataReader reader = comando.ExecuteReader();

            return reader;
        }

        public DataTable mysql_data_adapter()
        {
            DataTable dtb = new DataTable();

            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = this.string_conexao;
            try
            {
                conexao.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query_string, conexao);

                adapter.Fill(dtb);

                conexao.Dispose();
                adapter.Dispose();
            }
            catch
            {
            }
            return dtb;
        }

        public bool execute_non_query()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = this.string_conexao;
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = query_string;
                comando.Connection = conexao;
                comando.ExecuteNonQuery();

                conexao.Dispose();
                comando.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
