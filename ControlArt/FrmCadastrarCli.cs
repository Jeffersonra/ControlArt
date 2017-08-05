using System;
using System.Windows.Forms;
using ControlArt.ClassDB;

namespace ControlArt
{
    public partial class FrmCadastrarCli : Form
    {
        public FrmCadastrarCli()
        {
            InitializeComponent();
        }

        private void btnGrava_Click(object sender, EventArgs e)
        {
            try
            {
                //Modifica a data para inserir na tabela
                var data = DateTime.Parse(dtIdade.Text);
                var novaData = data.Year + "-" + data.Month + "-" + data.Day;
                data = DateTime.Now;
                var insertDate = data.Year + "-" + data.Month + "-" + data.Day;

                //Pega valor do RadioButton e valoda se esta preenchido
                var sexo = "";
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
                    throw new Exception("Selecione o Sexo!");
                }

                //Valida campos não prrenchidos
                if(txtEmail.Text == "" || txtNome.Text == "")
                {
                    throw new Exception();
                }

                //valida data
                if (data > DateTime.Now)
                {
                    throw new Exception();
                }

                //Conecta Sql
                Conecta cnn = new Conecta();
                cnn.query_string = "";

                cnn.query_string = "INSERT INTO tbclientes " +
                                   "VALUES(default,'" + txtNome.Text +
                                   "','" + txtEmail.Text +
                                   "','" + novaData +
                                   "','" + sexo + 
                                   "','" + insertDate + "')";
                // valida execução
                if (cnn.execute_non_query())
                {
                    txtEmail.Text = "";
                    txtNome.Text = "";
                    radioButtonF.Checked = false;
                    radioButtonM.Checked = false;
                    sexo = "";
                    MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos corretamente!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
