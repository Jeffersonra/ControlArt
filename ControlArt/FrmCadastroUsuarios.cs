using ControlArt.ClassDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlArt
{
    public partial class FrmCadastroUsuarios : Form
    {
        private DateTime data;
        private string Insertdata;

        public FrmCadastroUsuarios()
        {
            InitializeComponent();
            BuscaUsuarios();
            txtSenha.Text = "";
            txtSenha.PasswordChar = '*';
        }

        private void FrmCadastroUsuarios_Load(object sender, EventArgs e)
        {

        }

        #region "Eventos"
        /// <summary>
        /// Click do botão Sair
        /// </summary>
        /// <param name="sender"></param>
        /// /// <param name="e"></param>
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Click do botão Inserir Cadastro de usuários
        /// </summary>
        /// <param name="sender"></param>
        /// /// <param name="e"></param>
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (InsereDados())
                {
                    MessageBox.Show("Cadastro Realizado com Sucesso!", "Confirmação de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBoxUsuarios.Items.Clear();
                    BuscaUsuarios();
                }else
                {
                    MessageBox.Show("Erro ao inserir Cadastro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        /// <summary>
        /// Click do botão Redefinir Senha
        /// </summary>
        /// <param name="sender"></param>
        /// /// <param name="e"></param>
        private void btnRedefinir_Click(object sender, EventArgs e)
        {
            RedefineSenha();
        }

        #endregion

        #region "Métodos"

        /// <summary>
        /// Metodo para Insere os dados na base
        /// </summary>
        private bool InsereDados()
        {
            try
            {
                //Conecta Sql
                Conecta cnn = new Conecta();
                cnn.query_string = "";

                cnn.query_string = "INSERT INTO tbUsuarios(Login,Senha,Nome,InsertDate,Status)"+
                                    "VALUES('" + txtLogin.Text + "','"
                                    + txtSenha.Text + "','"
                                    + txtNome.Text + "','"
                                    + Insertdata + "','"
                                    + "A');";

                // valida execução
                if (cnn.GetExecute_non_query())
                {
                    txtLogin.Text = "";
                    txtNome.Text = "";
                    txtSenha.Text = "";
                    return true;
                }
                else
                {
                    throw new Exception();
                }

            }
            catch
            {

                return false;
            }
        }

        /// <summary>
        /// Metodo para Buscar usuários na base
        /// </summary>
        private void BuscaUsuarios()
        {
            Conecta cnn = new Conecta();
            cnn.query_string = "";

            cnn.query_string = "SELECT login FROM confusart_db.tbUsuarios order by Nome asc";

            DataTable tabela = new DataTable();
            tabela = cnn.Mysql_data_adapter();

            foreach (DataRow linha in tabela.Rows)
            {
                listBoxUsuarios.Items.Add(linha["login"]);
            }


        }

        /// <summary>
        /// Metodo para redefinir senha
        /// </summary>
        private bool RedefineSenha()
        {
            try
            {
                if(txtSenha.Text == "")
                {
                    MessageBox.Show("Por favor, Preencher campo Senha!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                //var teste = listBoxUsuarios.SelectedItem.ToString();

                if (listBoxUsuarios.SelectedItem == null )
                {
                    MessageBox.Show("Por favor, Selecione um usuário!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                var usuario = listBoxUsuarios.SelectedItem.ToString();

                //Conecta Sql
                Conecta cnn = new Conecta();
                cnn.query_string = "";

                cnn.query_string = "UPDATE tbUsuarios SET Senha = '" + txtSenha.Text 
                                    + "' WHERE Login = '" + usuario + "';";

                if (cnn.GetExecute_non_query())
                {
                    MessageBox.Show("Senha Redefinida com Sucesso!", "Redefinir Senha!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.Text = "";
                }
                else
                {
                    MessageBox.Show("Falha ao redefinir senha!", "Redefinir Senha!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.Text = "";
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region "Validações"

        /// <summary>
        /// Metodo para Validar Dados digitados
        /// </summary>
        private bool ValidaCampos()
        {
            try
            {

                //Modifica a data para inserir na tabela
                data = DateTime.Now;
                Insertdata = data.Year + "-" + data.Month + "-" + data.Day;
                
                //Valida campos não prrenchidos
                if (txtNome.Text == "")
                {
                    MessageBox.Show("Por favor, Preencher campo Nome!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (txtLogin.Text == "")
                {
                    MessageBox.Show("Por favor, Preencher campo Login!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Por favor, Preencher campo Senha!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

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
