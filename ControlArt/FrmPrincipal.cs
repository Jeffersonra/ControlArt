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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Modulos em desenvolvimento
        private void menuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modulo em desenvolvimento!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void consultarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modulo em desenvolvimento!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void vandasManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modulo em desenvolvimento!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pessoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modulo em desenvolvimento!", "Alerta!", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pagSeguroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modulo em desenvolvimento!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        //Load do Form
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        #region Menu: Arquivos
        /// <summary>
        /// Click do Botão para abrir o FrmCadastroUsuarios
        /// </summary>
        /// <param name="sender">o</param>
        /// <param name="e">o</param>
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuarios frmChild = new FrmCadastroUsuarios();
            frmChild.MdiParent = this;

            //Verifica se o form ja esta aberto se estiver da um focus no form.
            bool _found = false;

            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FrmCadastroUsuarios)
                {
                    _openForm.Focus();
                    _found = true;
                }
            }

            if (!_found)
            {
                FrmCadastroUsuarios _form2 = new FrmCadastroUsuarios();
                frmChild.Text = "Cadastro de Usuários";
                frmChild.Show();
            }
        }

        /// <summary>
        /// Click do Botão Fechar a Aplicação
        /// </summary>
        /// <param name="sender">o</param>
        /// <param name="e">o</param>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Menu: Cadastros

        /// <summary>
        /// Click do Botão para abrir a o FrmCadastroCli
        /// </summary>
        /// <param name="sender">o</param>
        /// <param name="e">o</param>
        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadastrarCli frmChild = new FrmCadastrarCli();
            frmChild.MdiParent = this;

            //Verifica se o form ja esta aberto se estiver da um focus no form.
            bool _found = false;

            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FrmCadastrarCli)
                {
                    _openForm.Focus();
                    _found = true;
                }
            }

            if (!_found)
            {
                FrmCadastrarCli _form2 = new FrmCadastrarCli();
                frmChild.Text = "Cadastro de Clientes";
                frmChild.Show();
            }
        }

        /// <summary>
        /// Click do Botão para abrir a o FrmCadastroUsuarios
        /// </summary>
        /// <param name="sender">o</param>
        /// <param name="e">o</param>
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaCli frmChild = new FrmConsultaCli();
            frmChild.MdiParent = this;

            //Verifica se o form ja esta aberto se estiver da um focus no form.
            bool _found = false;

            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FrmConsultaCli)
                {
                    _openForm.Focus();
                    _found = true;
                }
            }

            if (!_found)
            {
                FrmConsultaCli _form2 = new FrmConsultaCli();
                frmChild.Text = "Consulta Clientes";
                frmChild.Show();
            }
        }

        #endregion

        #region Menu: Vendas

        #endregion

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto frmChild = new FrmCadastroProduto();
            frmChild.MdiParent = this;

            //Verifica se o form ja esta aberto se estiver da um focus no form.
            bool _found = false;

            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FrmCadastrarCli)
                {
                    _openForm.Focus();
                    _found = true;
                }
            }

            if (!_found)
            {
                FrmCadastrarCli _form2 = new FrmCadastrarCli();
                frmChild.Text = "Consulta Produto";
                frmChild.Show();
            }
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadastrarCor frmChild = new FrmCadastrarCor();
            frmChild.MdiParent = this;

            //Verifica se o form ja esta aberto se estiver da um focus no form.
            bool _found = false;

            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FrmCadastrarCor)
                {
                    _openForm.Focus();
                    _found = true;
                }
            }

            if (!_found)
            {
                FrmCadastrarCor _form2 = new FrmCadastrarCor();
                frmChild.Text = "Cadastra Cor";
                frmChild.Show();
            }
        }

        private void cadastrarGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarGrupo frmChild = new FrmCadastrarGrupo();
            frmChild.MdiParent = this;

            //Verifica se o form ja esta aberto se estiver da um focus no form.
            bool _found = false;

            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FrmCadastrarGrupo)
                {
                    _openForm.Focus();
                    _found = true;
                }
            }

            if (!_found)
            {
                FrmCadastrarGrupo _form2 = new FrmCadastrarGrupo();
                frmChild.Text = "Cadastra Grupo";
                frmChild.Show();
            }
        }
    }
}
