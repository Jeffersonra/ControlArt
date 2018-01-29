namespace ControlArt
{
    partial class FrmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroProduto));
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblLargura = new System.Windows.Forms.Label();
            this.lblComprimento = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.grpDetalhes = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.cboTamanhoDetalhe = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.radDetalheNao = new System.Windows.Forms.RadioButton();
            this.radDetalheSim = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblAlteraDetalhe = new System.Windows.Forms.Label();
            this.lblNomeDetalhe = new System.Windows.Forms.Label();
            this.txtAlturaDetalhe = new System.Windows.Forms.TextBox();
            this.txtNomeDetalhe = new System.Windows.Forms.TextBox();
            this.lblComprimentoDetalhe = new System.Windows.Forms.Label();
            this.txtComprimentoDetalhe = new System.Windows.Forms.TextBox();
            this.lblTamanhoDetalhe = new System.Windows.Forms.Label();
            this.lblLarguraDetalhe = new System.Windows.Forms.Label();
            this.txtLarguraDetalhe = new System.Windows.Forms.TextBox();
            this.grdDetalhes = new System.Windows.Forms.DataGridView();
            this.menuStripProduto = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.grpProduto = new System.Windows.Forms.GroupBox();
            this.cboCor = new System.Windows.Forms.ComboBox();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTamanhoModelo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cboListaProdutosCadastrados = new System.Windows.Forms.ComboBox();
            this.cboDetalhesCadastrado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpDetalhes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalhes)).BeginInit();
            this.menuStripProduto.SuspendLayout();
            this.grpProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(8, 40);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 13);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "Modelo: ";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(8, 150);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(58, 13);
            this.lblTamanho.TabIndex = 5;
            this.lblTamanho.Text = "Tamanho: ";
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.Location = new System.Drawing.Point(8, 208);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(49, 13);
            this.lblLargura.TabIndex = 10;
            this.lblLargura.Text = "Largura: ";
            // 
            // lblComprimento
            // 
            this.lblComprimento.AutoSize = true;
            this.lblComprimento.Location = new System.Drawing.Point(9, 236);
            this.lblComprimento.Name = "lblComprimento";
            this.lblComprimento.Size = new System.Drawing.Size(74, 13);
            this.lblComprimento.TabIndex = 12;
            this.lblComprimento.Text = "Comprimento: ";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(9, 180);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 14;
            this.lblAltura.Text = "Altura:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(9, 262);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(37, 13);
            this.lblPeso.TabIndex = 16;
            this.lblPeso.Text = "Peso: ";
            // 
            // grpDetalhes
            // 
            this.grpDetalhes.Controls.Add(this.label4);
            this.grpDetalhes.Controls.Add(this.cboDetalhesCadastrado);
            this.grpDetalhes.Controls.Add(this.btnApagar);
            this.grpDetalhes.Controls.Add(this.cboTamanhoDetalhe);
            this.grpDetalhes.Controls.Add(this.groupBox1);
            this.grpDetalhes.Controls.Add(this.btnSalvar);
            this.grpDetalhes.Controls.Add(this.lblAlteraDetalhe);
            this.grpDetalhes.Controls.Add(this.lblNomeDetalhe);
            this.grpDetalhes.Controls.Add(this.txtAlturaDetalhe);
            this.grpDetalhes.Controls.Add(this.txtNomeDetalhe);
            this.grpDetalhes.Controls.Add(this.lblComprimentoDetalhe);
            this.grpDetalhes.Controls.Add(this.txtComprimentoDetalhe);
            this.grpDetalhes.Controls.Add(this.lblTamanhoDetalhe);
            this.grpDetalhes.Controls.Add(this.lblLarguraDetalhe);
            this.grpDetalhes.Controls.Add(this.txtLarguraDetalhe);
            this.grpDetalhes.Location = new System.Drawing.Point(258, 79);
            this.grpDetalhes.Name = "grpDetalhes";
            this.grpDetalhes.Size = new System.Drawing.Size(239, 300);
            this.grpDetalhes.TabIndex = 17;
            this.grpDetalhes.TabStop = false;
            this.grpDetalhes.Text = "Detalhes do Produto";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(157, 271);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(57, 23);
            this.btnApagar.TabIndex = 34;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // cboTamanhoDetalhe
            // 
            this.cboTamanhoDetalhe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTamanhoDetalhe.FormattingEnabled = true;
            this.cboTamanhoDetalhe.Location = new System.Drawing.Point(60, 147);
            this.cboTamanhoDetalhe.Name = "cboTamanhoDetalhe";
            this.cboTamanhoDetalhe.Size = new System.Drawing.Size(167, 21);
            this.cboTamanhoDetalhe.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDetalhes);
            this.groupBox1.Controls.Add(this.radDetalheNao);
            this.groupBox1.Controls.Add(this.radDetalheSim);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 35);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Location = new System.Drawing.Point(6, 14);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(85, 13);
            this.lblDetalhes.TabIndex = 18;
            this.lblDetalhes.Text = "Editar Detalhes?";
            // 
            // radDetalheNao
            // 
            this.radDetalheNao.AutoSize = true;
            this.radDetalheNao.Location = new System.Drawing.Point(153, 12);
            this.radDetalheNao.Name = "radDetalheNao";
            this.radDetalheNao.Size = new System.Drawing.Size(45, 17);
            this.radDetalheNao.TabIndex = 21;
            this.radDetalheNao.TabStop = true;
            this.radDetalheNao.Text = "Não";
            this.radDetalheNao.UseVisualStyleBackColor = true;
            this.radDetalheNao.CheckedChanged += new System.EventHandler(this.radDetalheNao_CheckedChanged);
            // 
            // radDetalheSim
            // 
            this.radDetalheSim.AutoSize = true;
            this.radDetalheSim.Location = new System.Drawing.Point(105, 12);
            this.radDetalheSim.Name = "radDetalheSim";
            this.radDetalheSim.Size = new System.Drawing.Size(42, 17);
            this.radDetalheSim.TabIndex = 20;
            this.radDetalheSim.TabStop = true;
            this.radDetalheSim.Text = "Sim";
            this.radDetalheSim.UseVisualStyleBackColor = true;
            this.radDetalheSim.CheckedChanged += new System.EventHandler(this.radDetalheSim_CheckedChanged_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(60, 271);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblAlteraDetalhe
            // 
            this.lblAlteraDetalhe.AutoSize = true;
            this.lblAlteraDetalhe.Location = new System.Drawing.Point(6, 177);
            this.lblAlteraDetalhe.Name = "lblAlteraDetalhe";
            this.lblAlteraDetalhe.Size = new System.Drawing.Size(40, 13);
            this.lblAlteraDetalhe.TabIndex = 31;
            this.lblAlteraDetalhe.Text = "Altura: ";
            // 
            // lblNomeDetalhe
            // 
            this.lblNomeDetalhe.AutoSize = true;
            this.lblNomeDetalhe.Location = new System.Drawing.Point(5, 106);
            this.lblNomeDetalhe.Name = "lblNomeDetalhe";
            this.lblNomeDetalhe.Size = new System.Drawing.Size(81, 13);
            this.lblNomeDetalhe.TabIndex = 20;
            this.lblNomeDetalhe.Text = "Nome Detalhe: ";
            // 
            // txtAlturaDetalhe
            // 
            this.txtAlturaDetalhe.Location = new System.Drawing.Point(46, 174);
            this.txtAlturaDetalhe.Name = "txtAlturaDetalhe";
            this.txtAlturaDetalhe.Size = new System.Drawing.Size(181, 20);
            this.txtAlturaDetalhe.TabIndex = 26;
            this.txtAlturaDetalhe.TextChanged += new System.EventHandler(this.txtAlturaDetalhe_TextChanged);
            // 
            // txtNomeDetalhe
            // 
            this.txtNomeDetalhe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeDetalhe.Location = new System.Drawing.Point(6, 122);
            this.txtNomeDetalhe.MaxLength = 150;
            this.txtNomeDetalhe.Name = "txtNomeDetalhe";
            this.txtNomeDetalhe.Size = new System.Drawing.Size(221, 20);
            this.txtNomeDetalhe.TabIndex = 22;
            // 
            // lblComprimentoDetalhe
            // 
            this.lblComprimentoDetalhe.AutoSize = true;
            this.lblComprimentoDetalhe.Location = new System.Drawing.Point(3, 234);
            this.lblComprimentoDetalhe.Name = "lblComprimentoDetalhe";
            this.lblComprimentoDetalhe.Size = new System.Drawing.Size(71, 13);
            this.lblComprimentoDetalhe.TabIndex = 29;
            this.lblComprimentoDetalhe.Text = "Comprimento:";
            // 
            // txtComprimentoDetalhe
            // 
            this.txtComprimentoDetalhe.Location = new System.Drawing.Point(75, 230);
            this.txtComprimentoDetalhe.Name = "txtComprimentoDetalhe";
            this.txtComprimentoDetalhe.Size = new System.Drawing.Size(152, 20);
            this.txtComprimentoDetalhe.TabIndex = 25;
            this.txtComprimentoDetalhe.TextChanged += new System.EventHandler(this.txtComprimentoDetalhe_TextChanged);
            // 
            // lblTamanhoDetalhe
            // 
            this.lblTamanhoDetalhe.AutoSize = true;
            this.lblTamanhoDetalhe.Location = new System.Drawing.Point(5, 151);
            this.lblTamanhoDetalhe.Name = "lblTamanhoDetalhe";
            this.lblTamanhoDetalhe.Size = new System.Drawing.Size(58, 13);
            this.lblTamanhoDetalhe.TabIndex = 22;
            this.lblTamanhoDetalhe.Text = "Tamanho: ";
            // 
            // lblLarguraDetalhe
            // 
            this.lblLarguraDetalhe.AutoSize = true;
            this.lblLarguraDetalhe.Location = new System.Drawing.Point(6, 204);
            this.lblLarguraDetalhe.Name = "lblLarguraDetalhe";
            this.lblLarguraDetalhe.Size = new System.Drawing.Size(49, 13);
            this.lblLarguraDetalhe.TabIndex = 27;
            this.lblLarguraDetalhe.Text = "Largura: ";
            // 
            // txtLarguraDetalhe
            // 
            this.txtLarguraDetalhe.Location = new System.Drawing.Point(60, 202);
            this.txtLarguraDetalhe.Name = "txtLarguraDetalhe";
            this.txtLarguraDetalhe.Size = new System.Drawing.Size(167, 20);
            this.txtLarguraDetalhe.TabIndex = 24;
            this.txtLarguraDetalhe.TextChanged += new System.EventHandler(this.txtLarguraDetalhe_TextChanged);
            // 
            // grdDetalhes
            // 
            this.grdDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalhes.Location = new System.Drawing.Point(510, 88);
            this.grdDetalhes.Name = "grdDetalhes";
            this.grdDetalhes.Size = new System.Drawing.Size(249, 286);
            this.grdDetalhes.TabIndex = 18;
            // 
            // menuStripProduto
            // 
            this.menuStripProduto.AllowMerge = false;
            this.menuStripProduto.AutoSize = false;
            this.menuStripProduto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.apagarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.menuStripProduto.Location = new System.Drawing.Point(0, 0);
            this.menuStripProduto.Name = "menuStripProduto";
            this.menuStripProduto.Size = new System.Drawing.Size(771, 76);
            this.menuStripProduto.TabIndex = 19;
            this.menuStripProduto.Text = "menuStripProduto";
            this.menuStripProduto.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripMenuItem.Image")));
            this.novoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeyDisplayString = "Novo";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(76, 72);
            this.novoToolStripMenuItem.Tag = "Novo";
            this.novoToolStripMenuItem.ToolTipText = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripMenuItem.Image")));
            this.salvarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(76, 72);
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // apagarToolStripMenuItem
            // 
            this.apagarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("apagarToolStripMenuItem.Image")));
            this.apagarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            this.apagarToolStripMenuItem.Size = new System.Drawing.Size(76, 72);
            this.apagarToolStripMenuItem.Click += new System.EventHandler(this.apagarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(76, 72);
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // txtLargura
            // 
            this.txtLargura.Location = new System.Drawing.Point(52, 205);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(178, 20);
            this.txtLargura.TabIndex = 6;
            this.txtLargura.TextChanged += new System.EventHandler(this.txtLargura_TextChanged_1);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(52, 177);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(178, 20);
            this.txtAltura.TabIndex = 5;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // txtComprimento
            // 
            this.txtComprimento.Location = new System.Drawing.Point(87, 233);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(143, 20);
            this.txtComprimento.TabIndex = 7;
            this.txtComprimento.TextChanged += new System.EventHandler(this.txtComprimento_TextChanged);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(52, 259);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(178, 20);
            this.txtPeso.TabIndex = 8;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Location = new System.Drawing.Point(11, 56);
            this.txtModelo.MaxLength = 150;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(221, 20);
            this.txtModelo.TabIndex = 1;
            // 
            // grpProduto
            // 
            this.grpProduto.Controls.Add(this.cboCor);
            this.grpProduto.Controls.Add(this.cboGrupo);
            this.grpProduto.Controls.Add(this.label3);
            this.grpProduto.Controls.Add(this.label2);
            this.grpProduto.Controls.Add(this.cboTamanhoModelo);
            this.grpProduto.Controls.Add(this.label1);
            this.grpProduto.Controls.Add(this.txtCodigo);
            this.grpProduto.Controls.Add(this.txtModelo);
            this.grpProduto.Controls.Add(this.txtPeso);
            this.grpProduto.Controls.Add(this.txtComprimento);
            this.grpProduto.Controls.Add(this.txtAltura);
            this.grpProduto.Controls.Add(this.txtLargura);
            this.grpProduto.Controls.Add(this.lblPeso);
            this.grpProduto.Controls.Add(this.lblAltura);
            this.grpProduto.Controls.Add(this.lblComprimento);
            this.grpProduto.Controls.Add(this.lblLargura);
            this.grpProduto.Controls.Add(this.lblTamanho);
            this.grpProduto.Controls.Add(this.lblModelo);
            this.grpProduto.Location = new System.Drawing.Point(12, 79);
            this.grpProduto.Name = "grpProduto";
            this.grpProduto.Size = new System.Drawing.Size(243, 300);
            this.grpProduto.TabIndex = 39;
            this.grpProduto.TabStop = false;
            this.grpProduto.Text = "Produto";
            this.grpProduto.Enter += new System.EventHandler(this.grpProduto_Enter);
            // 
            // cboCor
            // 
            this.cboCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCor.FormattingEnabled = true;
            this.cboCor.Location = new System.Drawing.Point(44, 117);
            this.cboCor.Name = "cboCor";
            this.cboCor.Size = new System.Drawing.Size(186, 21);
            this.cboCor.TabIndex = 3;
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(52, 87);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(178, 21);
            this.cboGrupo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Grupo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Cor: ";
            // 
            // cboTamanhoModelo
            // 
            this.cboTamanhoModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTamanhoModelo.FormattingEnabled = true;
            this.cboTamanhoModelo.Location = new System.Drawing.Point(70, 147);
            this.cboTamanhoModelo.Name = "cboTamanhoModelo";
            this.cboTamanhoModelo.Size = new System.Drawing.Size(159, 21);
            this.cboTamanhoModelo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(132, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 40;
            // 
            // cboListaProdutosCadastrados
            // 
            this.cboListaProdutosCadastrados.FormattingEnabled = true;
            this.cboListaProdutosCadastrados.Location = new System.Drawing.Point(318, 27);
            this.cboListaProdutosCadastrados.Name = "cboListaProdutosCadastrados";
            this.cboListaProdutosCadastrados.Size = new System.Drawing.Size(444, 21);
            this.cboListaProdutosCadastrados.TabIndex = 40;
            this.cboListaProdutosCadastrados.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboDetalhesCadastrado
            // 
            this.cboDetalhesCadastrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDetalhesCadastrado.FormattingEnabled = true;
            this.cboDetalhesCadastrado.Location = new System.Drawing.Point(6, 82);
            this.cboDetalhesCadastrado.Name = "cboDetalhesCadastrado";
            this.cboDetalhesCadastrado.Size = new System.Drawing.Size(221, 21);
            this.cboDetalhesCadastrado.TabIndex = 35;
            this.cboDetalhesCadastrado.SelectedIndexChanged += new System.EventHandler(this.cboDetalhesCadastrado_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Detalhes Cadastrados:";
            // 
            // FrmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 386);
            this.Controls.Add(this.cboListaProdutosCadastrados);
            this.Controls.Add(this.grpProduto);
            this.Controls.Add(this.grdDetalhes);
            this.Controls.Add(this.grpDetalhes);
            this.Controls.Add(this.menuStripProduto);
            this.MainMenuStrip = this.menuStripProduto;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroProduto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.FrmCadastroProduto_Load);
            this.grpDetalhes.ResumeLayout(false);
            this.grpDetalhes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalhes)).EndInit();
            this.menuStripProduto.ResumeLayout(false);
            this.menuStripProduto.PerformLayout();
            this.grpProduto.ResumeLayout(false);
            this.grpProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.Label lblComprimento;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.GroupBox grpDetalhes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblAlteraDetalhe;
        private System.Windows.Forms.Label lblNomeDetalhe;
        private System.Windows.Forms.TextBox txtNomeDetalhe;
        private System.Windows.Forms.RadioButton radDetalheNao;
        private System.Windows.Forms.Label lblComprimentoDetalhe;
        private System.Windows.Forms.RadioButton radDetalheSim;
        private System.Windows.Forms.Label lblTamanhoDetalhe;
        private System.Windows.Forms.Label lblLarguraDetalhe;
        private System.Windows.Forms.DataGridView grdDetalhes;
        private System.Windows.Forms.MenuStrip menuStripProduto;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDetalhes;
        private System.Windows.Forms.TextBox txtAlturaDetalhe;
        private System.Windows.Forms.TextBox txtComprimentoDetalhe;
        private System.Windows.Forms.TextBox txtLarguraDetalhe;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.GroupBox grpProduto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTamanhoDetalhe;
        private System.Windows.Forms.ComboBox cboTamanhoModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCor;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.ComboBox cboListaProdutosCadastrados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDetalhesCadastrado;
    }
}