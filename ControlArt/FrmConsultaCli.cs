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
using ControlArt;

namespace ControlArt
{
    public partial class FrmConsultaCli : Form
    {
        public FrmConsultaCli()
        {
            InitializeComponent();
        }

        private void FrmConsultaCli_Load(object sender, EventArgs e)
        {
            Conecta cnn = new Conecta();
            cnn.query_string = "";

            cnn.query_string = "SELECT * FROM confusart_db.tbclientes order by Nome asc;";

            DataTable tabela = new DataTable();
            tabela = cnn.mysql_data_adapter();

            foreach(DataRow linha in tabela.Rows)
            {
                dataGridViewCli.Rows.Add(linha); 
            }
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
