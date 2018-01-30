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
        private string codigoModelo;
        private int resultadoID;
        private DataTable GridDetalhe;
        public DataTable IdDetalhe;


        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            this.radDetalheNao.Checked = true;
            CarregaComboBoxForm();
        }
        
        //Instancia Classe para tratar campos do Form
        TrataCampos TrataCampos = new TrataCampos();

        #region MenuStripo
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrataCampos.LimparForms(this);
            this.grdDetalhes.DataSource = null;
            this.grdDetalhes.Refresh();
            this.radDetalheNao.Checked = true;
            codigoModelo = null;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ValidaCamposProduto())
            {
                MessageBox.Show("Por favor, Preencher todos os campos do Produto");
            }
            else if (String.IsNullOrEmpty(codigoModelo))
            {
                if (InsereProduto())
                {
                    MessageBox.Show("Produto Cadastrado");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Produto");
                }
            }
            else
            {
                if (AtualizaProduto())
                {
                    CarregaComboBoxForm();
                    MessageBox.Show("Produto Atualizado!");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar!");
                }
            }

        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente apagar o produto?", "Apagar Produto?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ApagarProdutoDetalhe(codigoModelo))
                {
                    MessageBox.Show("Produto Apagado!");
                    TrataCampos.LimparForms(this);
                    this.grdDetalhes.DataSource = null;
                    this.grdDetalhes.Refresh();
                    this.radDetalheNao.Checked = true;
                    CarregaComboBoxForm();
                }
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.grdDetalhes.DataSource = null;
            this.grdDetalhes.Refresh();
            this.radDetalheNao.Checked = true;
            codigoModelo = null;
            this.txtNomeDetalhe.Text = "";
            this.txtAlturaDetalhe.Text = "";
            this.txtLarguraDetalhe.Text = "";
            this.txtComprimentoDetalhe.Text = "";
            this.cboTamanhoDetalhe.SelectedIndex = -1;
            this.cboDetalhesCadastrado.SelectedIndex = -1;
            CarregaProduto();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        #endregion


        #region Validações
        private void radDetalheNao_CheckedChanged(object sender, EventArgs e)
        {
            if (radDetalheNao.Checked == true)
            {
                this.cboTamanhoDetalhe.Enabled = false;
                this.txtAlturaDetalhe.Enabled = false;
                this.txtComprimentoDetalhe.Enabled = false;
                this.txtLarguraDetalhe.Enabled = false;
                this.txtNomeDetalhe.Enabled = false;
                this.btnSalvar.Enabled = false;
                this.cboDetalhesCadastrado.Enabled = false;
            }
        }
        private void radDetalheSim_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radDetalheSim.Checked == true)
            {
                if (string.IsNullOrEmpty(codigoModelo))
                {
                    MessageBox.Show("Não é possível Cadastrar o Detalhe. Por favor,  Cadastre o Produto");
                    radDetalheNao.Checked = true;
                }
                else
                {
                    this.cboTamanhoDetalhe.Enabled = true;
                    this.txtAlturaDetalhe.Enabled = true;
                    this.txtComprimentoDetalhe.Enabled = true;
                    this.txtLarguraDetalhe.Enabled = true;
                    this.txtNomeDetalhe.Enabled = true;
                    this.btnSalvar.Enabled = true;
                    this.cboDetalhesCadastrado.Enabled = true;
                    PopulaGridDetalhes();
                    CarregaComboBoxDetalhes();

                }
            }

        }

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
                else if (cboTamanhoModelo.Text == "")
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
                else if (cboTamanhoDetalhe.Text == "")
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

        private void CarregaComboBoxForm()
        {
            this.cboCor.DataSource = BuscaCor();
            this.cboCor.ValueMember = "ID";
            this.cboCor.DisplayMember = "COR";

            this.cboGrupo.DataSource = BuscaGrupo();
            this.cboGrupo.ValueMember = "ID";
            this.cboGrupo.DisplayMember = "GRUPO";

            this.cboTamanhoModelo.DataSource = BuscaTamanho();
            this.cboTamanhoModelo.ValueMember = "ID";
            this.cboTamanhoModelo.DisplayMember = "Tamanho";

            this.cboTamanhoDetalhe.DataSource = BuscaTamanho();
            this.cboTamanhoDetalhe.ValueMember = "ID";
            this.cboTamanhoDetalhe.DisplayMember = "Tamanho";

            this.cboListaProdutosCadastrados.DataSource = ListaProdutosCadastrados();
            this.cboListaProdutosCadastrados.ValueMember = "ID";
            this.cboListaProdutosCadastrados.DisplayMember = "Modelo";
        }

        private void CarregaComboBoxDetalhes()
        {
            var detalhes = BuscaDetalhes();
            if (detalhes.Rows.Count > 0)
            {
                this.cboDetalhesCadastrado.DataSource = detalhes;
                this.cboDetalhesCadastrado.ValueMember = "ID";
                this.cboDetalhesCadastrado.DisplayMember = "Modelo";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaCamposProdutosDetalhes())
            {
                MessageBox.Show("Por favor, Preencher todos os campos dos Detalhes");
            }
            else if (InsereProdutoDetalhe())
            {
                PopulaGridDetalhes();
                CarregaComboBoxDetalhes();
            }
            else
            {

                MessageBox.Show("Não foi possivel salvar");
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente apagar o detalhe?", "Apagar detalhe?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (DeletaDetalhe())
                {
                    CarregaComboBoxDetalhes();
                    PopulaGridDetalhes();

                }
                else
                {
                    MessageBox.Show("Não foi Possível apagar.");
                }
            }
        }


        private bool InsereProduto()
        {
            try
            {
                data = DateTime.Now;
                Insertdata = data.Year + "-" + data.Month + "-" + data.Day;

                codigoModelo = txtModelo.Text.Substring(0, 3) + cboTamanhoModelo.Text;


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
                                    + "`IdCor`,"
                                    + "`IdGrupo`,"
                                    + "`DataInsert`,"
                                    + "`IdUsuario`)"
                                    + "VALUES"
                                    + "('" + codigoModelo + "',"
                                    + "'" + txtModelo.Text + "',"
                                    + "'" + cboTamanhoModelo.Text + "',"
                                    + txtAltura.Text + ","
                                    + txtLargura.Text + ","
                                    + txtComprimento.Text + ","
                                    + txtPeso.Text + ","
                                    + cboCor.SelectedValue + ","
                                    + cboGrupo.SelectedValue + ","
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

        private bool AtualizaProduto()
        {
            try
            {
                data = DateTime.Now;
                Insertdata = data.Year + "-" + data.Month + "-" + data.Day;

                var id = BuscaIdProduto();

                //Conecta Sql
                Conecta cnn = new Conecta();
                cnn.query_string = "";

                cnn.query_string = "UPDATE `confusart_db`.`tbProdutos`"
                                    + "SET "
                                    + "`Modelo` = '" + txtModelo.Text + "',"
                                    + "`Tamanho` = '" + cboTamanhoModelo.Text + "',"
                                    + "`Altura` = " + txtAltura.Text + ","
                                    + "`Largura` = " + txtLargura.Text + ","
                                    + "`Comprimento` = " + txtComprimento.Text + ","
                                    + "`Peso` = " + txtPeso.Text + ","
                                    + "`IdCor` = " + cboCor.SelectedValue + ","
                                    + "`IdGrupo` = " + cboGrupo.SelectedValue + ","
                                    + "`DataInsert` = '" + Insertdata + "',"
                                    + "`IdUsuario` = 01 "
                                    + "WHERE `ID` = " + id;

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

        private bool InsereProdutoDetalhe()
        {
            try
            {
                data = DateTime.Now;
                Insertdata = data.Year + "-" + data.Month + "-" + data.Day;

                var IdProduto = BuscaIdProduto();
                //Conecta Sql
                Conecta cnn = new Conecta();
                cnn.query_string = "";

                cnn.query_string = "INSERT INTO `confusart_db`.`tbProdutosDetalhes`"
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
                                    + "'" + cboTamanhoDetalhe.Text + "',"
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

        private bool ApagarProdutoDetalhe(string codigoModelo)
        {
            try
            {
                var idproduto = BuscaIdProduto();

                Conecta cnn = new Conecta();

                //BuscaIdDetalhes
                cnn.query_string = "";
                cnn.query_string = "SELECT ID FROM tbProdutosDetalhes WHERE CODIGOMODELO ='" + codigoModelo + "'";
                IdDetalhe = cnn.Mysql_data_adapter();

                //Deleta Detalhes
                foreach (DataRow item in IdDetalhe.Rows)
                {
                    cnn.query_string = "";
                    cnn.query_string = "DELETE FROM tbProdutosDetalhes WHERE ID = '" + item["ID"].ToString() + "'";
                    cnn.GetExecute_non_query();
                }

                //Deleta Produto
                cnn.query_string = "";
                cnn.query_string = "DELETE FROM tbProdutos WHERE ID = '" + idproduto + "'";
                cnn.GetExecute_non_query();

                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }

        private bool DeletaDetalhe()
        {
            try
            {
                var idDetalhe = cboDetalhesCadastrado.SelectedValue;

                Conecta cnn = new Conecta();


                cnn.query_string = "";
                cnn.query_string = "DELETE FROM tbProdutosDetalhes WHERE ID = '" + idDetalhe + "'";
                cnn.GetExecute_non_query();


                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private int BuscaIdProduto()
        {
            Conecta cnn = new Conecta();
            cnn.query_string = "";

            cnn.query_string = "SELECT ID FROM tbProdutos WHERE CodigoModelo = '" + codigoModelo + "'";

            var IdProduto = cnn.Mysql_data_reader();

            while (IdProduto.Read())
            {
                resultadoID = Convert.ToInt16(IdProduto["ID"]);
            }

            return resultadoID;
        }

        private void PopulaGridDetalhes()
        {
            GridDetalhe = BuscaDetalhes();

            if (GridDetalhe.Rows.Count > 0)
            {
                grdDetalhes.DataSource = GridDetalhe;
            }


        }

        private DataTable BuscaDetalhes()
        {
            Conecta cnn = new Conecta();
            cnn.query_string = "";
            cnn.query_string = "SELECT ID, Modelo FROM tbProdutosDetalhes where CodigoModelo = '" + codigoModelo + "';";

            var tabela = cnn.Mysql_data_adapter();

            return tabela;

        }

        private DataTable BuscaCor()
        {
            Conecta cnn = new Conecta();
            cnn.query_string = "";
            cnn.query_string = "select ID, COR from tbCorProduto order by cor;";

            var tabela = cnn.Mysql_data_adapter();

            return tabela;

        }

        private DataTable BuscaGrupo()
        {
            Conecta cnn = new Conecta();
            cnn.query_string = "";
            cnn.query_string = "select ID, GRUPO from tbGrupoProduto order by GRUPO;";

            var tabela = cnn.Mysql_data_adapter();

            return tabela;

        }

        private DataTable BuscaTamanho()
        {
            Conecta cnn = new Conecta();
            cnn.query_string = "";
            cnn.query_string = "select ID, tamanho from tbTamanho order by  tamanho desc;";

            var tabela = cnn.Mysql_data_adapter();

            return tabela;

        }

        private DataTable ListaProdutosCadastrados()
        {
            Conecta cnn = new Conecta();
            cnn.query_string = "";
            cnn.query_string = "SELECT ID, Modelo FROM tbProdutos;";

            var tabela = cnn.Mysql_data_adapter();

            return tabela;
        }

        private void grpProduto_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CarregaProduto()
        {
            Conecta cnn = new Conecta();
            cnn.query_string = "";
            cnn.query_string = "SELECT ID, codigoModelo, Modelo, Tamanho, Altura, Largura, Comprimento, peso, idCor, idGrupo FROM tbProdutos where ID = " + this.cboListaProdutosCadastrados.SelectedValue;

            var tabela = cnn.Mysql_data_reader();


            while (tabela.Read())
            {
                this.txtModelo.Text = Convert.ToString(tabela["Modelo"]);
                this.txtAltura.Text = Convert.ToString(tabela["Altura"]);
                this.txtLargura.Text = Convert.ToString(tabela["Largura"]);
                this.txtComprimento.Text = Convert.ToString(tabela["Comprimento"]);
                this.txtPeso.Text = Convert.ToString(tabela["peso"]);
                codigoModelo = Convert.ToString(tabela["codigoModelo"]);
                this.txtCodigo.Text = codigoModelo;

            }

        }

        private void cboDetalhesCadastrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscaDadosDetalhes();
        }

        private void BuscaDadosDetalhes()
        {
            Conecta cnn = new Conecta();
            cnn.query_string = "";
            //var teste = cboDetalhesCadastrado.SelectedText;
            cnn.query_string = "SELECT ID, IdProduto, CodigoModelo,Modelo, Tamanho, Altura, Largura, Comprimento FROM tbProdutosDetalhes where CodigoModelo = '" + codigoModelo + "' and id = \"" + cboDetalhesCadastrado.SelectedValue + "\";";

            var tabela = cnn.Mysql_data_reader();

            while (tabela.Read())
            {
                this.txtNomeDetalhe.Text = Convert.ToString(tabela["Modelo"]);
                this.txtAlturaDetalhe.Text = Convert.ToString(tabela["Altura"]);
                this.txtLarguraDetalhe.Text = Convert.ToString(tabela["Largura"]);
                this.txtComprimentoDetalhe.Text = Convert.ToString(tabela["Comprimento"]);
            }
        }

    }
}
