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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtSenha.Text = "";
            txtSenha.PasswordChar = '*';
        }

        #region "Eventos"
        /// <summary>
        /// KeyDown> Ao teclar enter irá simular o botão entrar
        /// </summary>
        /// <param name="sender">o</param>
        /// <param name="e">o</param>
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ValidaLoginSenha())
                {
                    if (buscaUsuario())
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Login ou Senha Invalidos!", "Login ControlArt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        /// <summary>
        /// Click do Botão Sair
        /// </summary>
        /// <param name="sender">o</param>
        /// <param name="e">o</param>
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Click do Botão Entrar
        /// </summary>
        /// <param name="sender">o</param>
        /// <param name="e">o</param>
        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (ValidaLoginSenha())
            {
                if(buscaUsuario())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Login ou Senha Invalidos!", "Login ControlArt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        #endregion

        #region "Métodos"

        /// <summary>
        /// Metodo Buscar usuário
        /// </summary>
        private bool buscaUsuario()
        {
            try
            {
                //Conecta Sql
                Conecta cnn = new Conecta();
                cnn.query_string = "";

                cnn.query_string = "SELECT * FROM confusart_db.tbUsuarios WHERE LOGIN = '" + txtLogin.Text + "' AND SENHA = '" + txtSenha.Text + "' AND STATUS = 'A';";

                cnn.GetExecute_non_query();

                var resultado = cnn.Mysql_data_reader().Read().ToString();
                if (resultado == "True")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Erro ao Acessar Banco de Dados","Login ControlArt",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        #region "Validações"

        /// <summary>
        /// Metodo Valida Login e Senha
        /// </summary>
        private bool ValidaLoginSenha()
        {
            try
            {
                if (txtLogin.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("Por favor, Preencher Login e Senha!", "Login ControlArt", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}