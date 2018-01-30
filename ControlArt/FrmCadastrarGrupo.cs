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
    public partial class FrmCadastrarGrupo : Form
    {
        public FrmCadastrarGrupo()
        {
            InitializeComponent();
        }

        private void btnCadastraGrupo_Click(object sender, EventArgs e)
        {
            if (InserirGrupo())
            {
                MessageBox.Show("Grupo Inserido Com sucesso!");
                this.txtCadastroGrupo.Text = "";
            }
            else
            {
                MessageBox.Show("Não foi possível Inserir!");
            }
        }

        private bool InserirGrupo()
        {
            try
            {
                var data = DateTime.Now;
                var Insertdata = data.Year + "-" + data.Month + "-" + data.Day;

                //Conecta Sql
                Conecta cnn = new Conecta();
                cnn.query_string = "";

                cnn.query_string = "INSERT INTO `confusart_db`.`tbGrupoProduto`"
                                + "(`Grupo`,"
                                + "`DataInsert`,"
                                + "`IdUsuario`)"
                                + "VALUES"
                                + "('" + txtCadastroGrupo.Text + "',"
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
    }
}
