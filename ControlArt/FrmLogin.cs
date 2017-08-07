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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private bool buscaUsuario()
        {
            try
            {
                //Conecta Sql
                Conecta cnn = new Conecta();
                cnn.query_string = "";

                cnn.query_string = "SELECT * FROM confusart_db.tbUsuarios WHERE LOGIN = '" + txtLogin.Text + "' AND SENHA = '" + txtSenha.Text + "' AND STATUS = 'A';";

                cnn.execute_non_query();

                var resultado = cnn.mysql_data_reader().Read().ToString();
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