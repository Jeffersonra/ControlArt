using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlArt.Funcoes;
using ControlArt.ClassDB;

namespace ControlArt
{
    public partial class FrmCadastroProduto : Form
    {
        private DateTime data;
        private string Insertdata;
        private string tamanho;
        private string codigoModelo;
        private int resultadoID;


        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            this.radDetalheNao.Checked = true;
            this.radP.Checked = false;
        }



        //Instancia Classe para tratar campos do Form
        TrataCampos TrataCampos = new TrataCampos();

        #region MenuStripo
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrataCampos.LimparForms(this);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ValidaCamposProduto())
            {
                MessageBox.Show("Por favor, Preencher todos os campos do Produto");
            }
            else if (InsereProduto())
            {
                MessageBox.Show("Produto Cadastrado");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar Produto");
            }
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        #endregion

        #region RadioButton Detalhes
        private void radDetalheNao_CheckedChanged(object sender, EventArgs e)
        {
            if (radDetalheNao.Checked == true)
            {
                this.radDetalheG.Enabled = false;
                this.radDetalheM.Enabled = false;
                this.radDetalheP.Enabled = false;
                this.txtAlturaDetalhe.Enabled = false;
                this.txtComprimentoDetalhe.Enabled = false;
                this.txtLarguraDetalhe.Enabled = false;
                this.txtNomeDetalhe.Enabled = false;
                this.btnSalvar.Enabled = false;
            }
        }
        private void radDetalheSim_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radDetalheSim.Checked == true)
            {
                this.radDetalheG.Enabled = true;
                this.radDetalheM.Enabled = true;
                this.radDetalheP.Enabled = true;
                this.txtAlturaDetalhe.Enabled = true;
                this.txtComprimentoDetalhe.Enabled = true;
                this.txtLarguraDetalhe.Enabled = true;
                this.txtNomeDetalhe.Enabled = true;
                this.btnSalvar.Enabled = true;
            }
        }
        #endregion

        #region Validações

        /// <summary>
        /// Metodo para Validar Dados digitados dos Produtos
        /// </summary>
        private bool ValidaCamposProduto()
        {
            try
            {
                if (this.txtModelo.Text == "")
                {
                    return false;
                }
                else if (this.txtLargura.Text == "")
                {
                    return false;
                }
                else if (this.txtComprimento.Text == "")
                {
                    return false;
                }
                else if (this.txtAltura.Text == "")
                {
                    return false;
                }
                else if (this.txtPeso.Text == "")
                {
                    return false;
                }
                else if (radP.Checked == false && radM.Checked == false && radG.Checked == false)
                {
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo para Validar Dados digitados dos detalhes 
        /// </summary>
        private bool ValidaCamposProdutosDetalhes()
        {
            try
            {
                if (this.txtNomeDetalhe.Text == "")
                {
                    return false;
                }
                else if (this.txtLarguraDetalhe.Text == "")
                {
                    return false;
                }
                else if (this.txtComprimentoDetalhe.Text == "")
                {
                    return false;
                }
                else if (this.txtAlturaDetalhe.Text == "")
                {
                    return false;
                }
                else if (radDetalheP.Checked == false && radDetalheM.Checked == false && radDetalheG.Checked == false)
                {
                    return false;
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region TextBoxValidação

        private void txtLargura_TextChanged_1(object sender, EventArgs e)
        {
            TrataCampos.RecebeApenasNumeros(this.txtLargura);
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            TrataCampos.RecebeApenasNumeros(this.txtAltura);
        }

        private void txtComprimento_TextChanged(object sender, EventArgs e)
        {
            TrataCampos.RecebeApenasNumeros(this.txtComprimento);
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            TrataCampos.RecebeApenasNumeros(this.txtPeso);
        }

        private void txtLarguraDetalhe_TextChanged(object sender, EventArgs e)
        {
            TrataCampos.RecebeApenasNumeros(this.txtLarguraDetalhe);
        }

        private void txtComprimentoDetalhe_TextChanged(object sender, EventArgs e)
        {
            TrataCampos.RecebeApenasNumeros(this.txtComprimentoDetalhe);
        }

        private void txtAlturaDetalhe_TextChanged(object sender, EventArgs e)
        {
            TrataCampos.RecebeApenasNumeros(this.txtAlturaDetalhe);
        }
        #endregion

        #endregion

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaCamposProdutosDetalhes())
            {
                MessageBox.Show("Por favor, Preencher todos os campos dos Detalhes");
            }
            else if (InsereProdutoDetalhe())
            {
                MessageBox.Show("Inserido com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possivel salvar");
            }
        }


        private bool InsereProduto()
        {
            try
            {
                data = DateTime.Now;
                Insertdata = data.Year + "-" + data.Month + "-" + data.Day;

                tamanho = TrataCampos.RadioSelecionado(this.grpProduto);

                codigoModelo = txtModelo.Text.Substring(0, 3) + tamanho;


                //Conecta Sql
                Conecta cnn = new Conecta();
                cnn.query_string = "";

                cnn.query_string = "INSERT INTO `confusart_db`.`tbProdutos`"
                                    + " (`CodigoModelo`,"
                                    + "`Modelo`,"
                                    + "`Tamanho`,"
                                    + "`Altura`,"
                                    + "`Largura`,"
                                    + "`Comprimento`,"
                                    + "`Peso`,"
                                    + "`DataInsert`,"
                                    + "`IdUsuario`)"
                                    + "VALUES"
                                    + "('" + codigoModelo + "',"
                                    + "'" + txtModelo.Text + "',"
                                    + "'" + tamanho + "',"
                                    + txtAltura.Text + ","
                                    + txtLargura.Text + ","
                                    + txtComprimento.Text + ","
                                    + txtPeso.Text + ","
                                    + "'" + Insertdata + "',"
                                    + " 01)";


                // valida execução
                if (cnn.GetExecute_non_query())
                {
                    this.txtCodigo.Text = codigoModelo;
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

        private bool InsereProdutoDetalhe()
        {
            try
            {
                data = DateTime.Now;
                Insertdata = data.Year + "-" + data.Month + "-" + data.Day;

                tamanho = "";
                tamanho = TrataCampos.RadioSelecionado(this.grdDetalhes); //Corrigir Seleção do radio Buton

                var IdProduto = BuscaIdProduto();
                //Conecta Sql
                Conecta cnn = new Conecta();
                cnn.query_string = "";

                cnn.query_string = "INSERT INTO `confusart_db`.`tbprodutosdetalhes`"
                                    + "(`IdProduto`,"
                                    + "`CodigoModelo`,"
                                    + "`Modelo`,"
                                    + "`Tamanho`,"
                                    + "`Altura`,"
                                    + "`Largura`,"
                                    + "`Comprimento`,"
                                    + "`DataInsert`,"
                                    + "`IdUsuario`)"
                                    + "VALUES"
                                    + "('" + IdProduto + "',"
                                    + "'" + codigoModelo + "',"
                                    + "'" + this.txtNomeDetalhe.Text + "',"
                                    + "'" + tamanho + "',"
                                    + this.txtAlturaDetalhe.Text + ","
                                    + txtLarguraDetalhe.Text + ","
                                    + txtComprimentoDetalhe.Text + ","
                                    + "'" + Insertdata + "',"
                                    + " 01)";


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

        private int BuscaIdProduto()
        {
            Conecta cnn = new Conecta();
            cnn.query_string = "";

            cnn.query_string = "SELECT ID FROM tbprodutos WHERE CodigoModelo = '" + codigoModelo + "'";

            var IdProduto = cnn.Mysql_data_reader();

            while (IdProduto.Read())
            {
                resultadoID = Convert.ToInt16(IdProduto["ID"]);
            }                

            return resultadoID;
        }
    }
}
