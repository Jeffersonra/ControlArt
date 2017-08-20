namespace ControlArt
{
    partial class FrmConsultaCli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCli = new System.Windows.Forms.DataGridView();
            this.btnExportXLS = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExportaCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCli)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de clientes";
            // 
            // dataGridViewCli
            // 
            this.dataGridViewCli.AllowUserToAddRows = false;
            this.dataGridViewCli.AllowUserToDeleteRows = false;
            this.dataGridViewCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCli.Location = new System.Drawing.Point(12, 43);
            this.dataGridViewCli.Name = "dataGridViewCli";
            this.dataGridViewCli.ReadOnly = true;
            this.dataGridViewCli.Size = new System.Drawing.Size(695, 298);
            this.dataGridViewCli.TabIndex = 1;
            // 
            // btnExportXLS
            // 
            this.btnExportXLS.Location = new System.Drawing.Point(185, 364);
            this.btnExportXLS.Name = "btnExportXLS";
            this.btnExportXLS.Size = new System.Drawing.Size(112, 23);
            this.btnExportXLS.TabIndex = 2;
            this.btnExportXLS.Text = "Exportar XLS";
            this.btnExportXLS.UseVisualStyleBackColor = true;
            this.btnExportXLS.Click += new System.EventHandler(this.btnExportXLS_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(632, 364);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExportaCSV
            // 
            this.btnExportaCSV.Location = new System.Drawing.Point(333, 364);
            this.btnExportaCSV.Name = "btnExportaCSV";
            this.btnExportaCSV.Size = new System.Drawing.Size(112, 23);
            this.btnExportaCSV.TabIndex = 5;
            this.btnExportaCSV.Text = "Exportar CSV";
            this.btnExportaCSV.UseVisualStyleBackColor = true;
            this.btnExportaCSV.Click += new System.EventHandler(this.btnExportaCSV_Click);
            // 
            // FrmConsultaCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 412);
            this.Controls.Add(this.btnExportaCSV);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExportXLS);
            this.Controls.Add(this.dataGridViewCli);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmConsultaCli";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Clientes";
            this.Load += new System.EventHandler(this.FrmConsultaCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCli;
        private System.Windows.Forms.Button btnExportXLS;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExportaCSV;
    }
}