using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlArt.Funcoes;

namespace ControlArt
{
    public partial class FrmCadastroProduto : Form
    {
        public FrmCadastroProduto()
        {
            InitializeComponent();


        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            this.radDetalheNao.Checked = true;
            this.radP.Checked = false;
        }

        #region MenuStripo
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpaCampos limpar = new LimpaCampos();
            limpar.ClearForm(this);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            }
        }
        #endregion


    }
}
