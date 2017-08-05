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

        //Menu Form
        private void cadastrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
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

        //Load do Form
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        #region Modulos em desenvolvimento
        private void menuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modulo em desenvolvimento!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
