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
using ControlArt.Funcoes;

using Microsoft.Office.Interop;


namespace ControlArt
{
    public partial class FrmConsultaCli : Form
    {
        DataTable tabela = new DataTable();

        public FrmConsultaCli()
        {
            InitializeComponent();
        }

        #region "Eventos"

        /// <summary>
        /// Load da tela, onde ja carrega os dados do relatório para visualização previa.
        /// </summary>
        private void FrmConsultaCli_Load(object sender, EventArgs e)
        {
            Conecta cnn = new Conecta();
            cnn.query_string = "";

            cnn.query_string = "SELECT ID,NOME,EMAIL, date_format(DTNASCIMENTO, '%d/%m/%Y') as DT_NASCIMENTO, SEXO, TELEFONE FROM confusart_db.tbclientes order by ID asc;";

            tabela = cnn.mysql_data_adapter();

            dataGridViewCli.DataSource = tabela;

        }

        /// <summary>
        /// Click do Botão Sair
        /// </summary>
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Click do Botão Exportar .Xls
        /// </summary>
        private void btnExportXLS_Click(object sender, EventArgs e)
        {

            ExportarArquivo exporta = new ExportarArquivo();

            SaveFileDialog caminho = new SaveFileDialog();
            caminho.Filter = "XLSX | *.xlsx";
            caminho.Title = "Salvar Relatório";
            caminho.ShowDialog();

            if (!string.IsNullOrEmpty(caminho.FileName))
            {
                if (exporta.ExportarXLS(tabela, caminho.FileName))
                {
                    MessageBox.Show("Relatório gerado com sucesso!", "Gerar relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Flaha ao gerar relatório!", "Gerar relatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Click do Botão Exportar .CSV
        /// </summary>
        /// <param name="ds">Tabela com o relatório</param>
        private void btnExportaCSV_Click(object sender, EventArgs e)
        {
            ExportarArquivo exporta = new ExportarArquivo();

            SaveFileDialog caminho = new SaveFileDialog();
            caminho.Filter = "CSV|*.csv";
            caminho.Title = "Salvar Relatório";
            caminho.ShowDialog();

            if (!string.IsNullOrEmpty(caminho.FileName))
            {
                if (exporta.ExportarCSV(tabela, caminho.FileName))
                {
                    MessageBox.Show("Relatório gerado com sucesso!", "Gerar relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Flaha ao gerar relatório!", "Gerar relatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}
