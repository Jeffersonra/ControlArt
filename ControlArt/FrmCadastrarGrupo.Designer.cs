namespace ControlArt
{
    partial class FrmCadastrarGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarGrupo));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastraGrupo = new System.Windows.Forms.Button();
            this.txtCadastroGrupo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Informe o Grupo:";
            // 
            // btnCadastraGrupo
            // 
            this.btnCadastraGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastraGrupo.Image")));
            this.btnCadastraGrupo.Location = new System.Drawing.Point(316, 11);
            this.btnCadastraGrupo.Name = "btnCadastraGrupo";
            this.btnCadastraGrupo.Size = new System.Drawing.Size(75, 78);
            this.btnCadastraGrupo.TabIndex = 4;
            this.btnCadastraGrupo.UseVisualStyleBackColor = true;
            this.btnCadastraGrupo.Click += new System.EventHandler(this.btnCadastraGrupo_Click);
            // 
            // txtCadastroGrupo
            // 
            this.txtCadastroGrupo.Location = new System.Drawing.Point(10, 41);
            this.txtCadastroGrupo.Name = "txtCadastroGrupo";
            this.txtCadastroGrupo.Size = new System.Drawing.Size(300, 20);
            this.txtCadastroGrupo.TabIndex = 3;
            // 
            // FrmCadastrarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastraGrupo);
            this.Controls.Add(this.txtCadastroGrupo);
            this.MaximizeBox = false;
            this.Name = "FrmCadastrarGrupo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Grupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastraGrupo;
        private System.Windows.Forms.TextBox txtCadastroGrupo;
    }
}