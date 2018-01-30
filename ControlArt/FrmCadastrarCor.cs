using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlArt.ClassDB;

namespace ControlArt
{
    public partial class FrmCadastrarCor : Form
    {
        public FrmCadastrarCor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InserirCor())
            {
                MessageBox.Show("Cor Inserida Com sucesso!");
                this.txtCadastroCor.Text = "";
            }
            else
            {
                MessageBox.Show("Não foi possível Inserir!");
            }
        }

        private bool InserirCor()
        {
            try
            {
                var data = DateTime.Now;
                var Insertdata = data.Year + "-" + data.Month + "-" + data.Day;

                //Conecta Sql
                Conecta cnn = new Conecta();
                cnn.query_string = "";

                cnn.query_string = "INSERT INTO `confusart_db`.`tbCorProduto`"
                                + "(`Cor`,"
                                + "`DataInsert`,"
                                + "`IdUsuario`)"
                                + "VALUES"
                                + "('" + txtCadastroCor.Text + "',"
                                + "'" + Insertdata + "',"
                                + "01);";


                // valida execução
                if (cnn.GetExecute_non_query())
                {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCadastroCor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
