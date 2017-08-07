using System;
using System.Windows.Forms;
using ControlArt.ClassDB;
using System.Text.RegularExpressions;

namespace ControlArt
{
    public partial class FrmCadastrarCli : Form
    {
        private DateTime data;
        private string novaData;
        private string insertDate;
        private string sexo = "";

        public FrmCadastrarCli()
        {
            InitializeComponent();
        }

        private void FrmCadastrarCli_Load(object sender, EventArgs e)
        {

        }

        #region "Eventos"
        private void btnGrava_Click(object sender, EventArgs e)
        {
                if (ValidaCampos())
                {
                    if (InsereDados())
                    {
                        MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                    {
                        MessageBox.Show("Erro ao gravar dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }   
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Métodos"

        private bool InsereDados()
        {
            try
            {
                //Conecta Sql
                Conecta cnn = new Conecta();
                cnn.query_string = "";

                cnn.query_string = "INSERT INTO tbclientes " +
                                   "VALUES(default,'" + txtNome.Text +
                                   "','" + txtEmail.Text +
                                   "','" + novaData +
                                   "','" + sexo +
                                   "','" + insertDate +
                                   "','" + txtTel.Text + "')";
                // valida execução
                if (cnn.execute_non_query())
                {
                    txtEmail.Text = "";
                    txtNome.Text = "";
                    radioButtonF.Checked = false;
                    radioButtonM.Checked = false;
                    sexo = "";
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

        #endregion

        #region "Validações"

        private bool ValidaCampos()
        {
            try
            {
       
                //Modifica a data para inserir na tabela
                data = DateTime.Parse(dtIdade.Text);
                DateTime dateLimite = new DateTime(1940, 1, 1, 0, 0, 0);
                //Valida data Minima
                if (data < dateLimite)
                {
                    MessageBox.Show("A data não pode ser menor que 1940", "Data inválida!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                //Valida data Maxima
                if (data > DateTime.Now)
                {
                    MessageBox.Show("A data não pode ser maior que a data atual!", "Data inválida!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                novaData = data.Year + "-" + data.Month + "-" + data.Day;
                data = DateTime.Now;
                insertDate = data.Year + "-" + data.Month + "-" + data.Day;

                //Pega valor do RadioButton e valoda se esta preenchido
                sexo = "";
                if (radioButtonF.Checked)
                {
                    sexo = "F";
                }
                else if (radioButtonM.Checked)
                {
                    sexo = "M";
                }
                else
                {
                    MessageBox.Show("Selecione o Sexo!","Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                //Valida campos não prrenchidos
                if (txtNome.Text == "")
                {
                    MessageBox.Show("Por favor, Preencher campo Nome!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Por favor, Preencher campo E-mail!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    string email = txtEmail.Text;

                    Regex rg = new Regex(@"([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

                    if (!rg.IsMatch(email))
                    {
                        MessageBox.Show("Email Inválido!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
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
