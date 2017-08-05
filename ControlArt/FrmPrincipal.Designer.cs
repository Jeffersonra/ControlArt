namespace ControlArt
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirVendasPagSeguroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagSeguroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vandasManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(942, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            this.menuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuPrincipal_ItemClicked);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClientesToolStripMenuItem,
            this.cadastrarProdutosToolStripMenuItem,
            this.consultarClientesToolStripMenuItem,
            this.consultarProdutosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrarClientesToolStripMenuItem
            // 
            this.cadastrarClientesToolStripMenuItem.Name = "cadastrarClientesToolStripMenuItem";
            this.cadastrarClientesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cadastrarClientesToolStripMenuItem.Text = "Cadastrar Clientes";
            this.cadastrarClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClientesToolStripMenuItem_Click);
            // 
            // cadastrarProdutosToolStripMenuItem
            // 
            this.cadastrarProdutosToolStripMenuItem.Name = "cadastrarProdutosToolStripMenuItem";
            this.cadastrarProdutosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cadastrarProdutosToolStripMenuItem.Text = "Cadastrar Produtos";
            this.cadastrarProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutosToolStripMenuItem_Click);
            // 
            // consultarClientesToolStripMenuItem
            // 
            this.consultarClientesToolStripMenuItem.Name = "consultarClientesToolStripMenuItem";
            this.consultarClientesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.consultarClientesToolStripMenuItem.Text = "Consultar Clientes";
            this.consultarClientesToolStripMenuItem.Click += new System.EventHandler(this.consultarClientesToolStripMenuItem_Click);
            // 
            // consultarProdutosToolStripMenuItem
            // 
            this.consultarProdutosToolStripMenuItem.Name = "consultarProdutosToolStripMenuItem";
            this.consultarProdutosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.consultarProdutosToolStripMenuItem.Text = "Consultar Produtos";
            this.consultarProdutosToolStripMenuItem.Click += new System.EventHandler(this.consultarProdutosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirVendasPagSeguroToolStripMenuItem,
            this.vandasManualToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // incluirVendasPagSeguroToolStripMenuItem
            // 
            this.incluirVendasPagSeguroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagSeguroToolStripMenuItem,
            this.pessoalToolStripMenuItem});
            this.incluirVendasPagSeguroToolStripMenuItem.Name = "incluirVendasPagSeguroToolStripMenuItem";
            this.incluirVendasPagSeguroToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.incluirVendasPagSeguroToolStripMenuItem.Text = "Registrar Vendas";
            // 
            // pagSeguroToolStripMenuItem
            // 
            this.pagSeguroToolStripMenuItem.Name = "pagSeguroToolStripMenuItem";
            this.pagSeguroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pagSeguroToolStripMenuItem.Text = "PagSeguro";
            this.pagSeguroToolStripMenuItem.Click += new System.EventHandler(this.pagSeguroToolStripMenuItem_Click);
            // 
            // pessoalToolStripMenuItem
            // 
            this.pessoalToolStripMenuItem.Name = "pessoalToolStripMenuItem";
            this.pessoalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pessoalToolStripMenuItem.Text = "Pessoal";
            this.pessoalToolStripMenuItem.Click += new System.EventHandler(this.pessoalToolStripMenuItem_Click);
            // 
            // vandasManualToolStripMenuItem
            // 
            this.vandasManualToolStripMenuItem.Name = "vandasManualToolStripMenuItem";
            this.vandasManualToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.vandasManualToolStripMenuItem.Text = "Consultar Vendas";
            this.vandasManualToolStripMenuItem.Click += new System.EventHandler(this.vandasManualToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 441);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "ControlArt  - Confusart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirVendasPagSeguroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagSeguroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vandasManualToolStripMenuItem;
    }
}