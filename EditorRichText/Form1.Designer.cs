namespace EditorRichText
{
    partial class formEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarImpressãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarImpressãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNewFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripFonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripCode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAlingLeft = new System.Windows.Forms.ToolStripButton();
            this.toolStripAlingCenter = new System.Windows.Forms.ToolStripButton();
            this.toolStripAlingRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripConfigPrinter = new System.Windows.Forms.ToolStripButton();
            this.toolStripPrinter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripGit = new System.Windows.Forms.ToolStripButton();
            this.rtxtb1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.alterarTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.claroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.opcoesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirArquivoToolStripMenuItem,
            this.salvarArquivoToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.refazerToolStripMenuItem,
            this.desfazerToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirArquivoToolStripMenuItem
            // 
            this.abrirArquivoToolStripMenuItem.Name = "abrirArquivoToolStripMenuItem";
            this.abrirArquivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirArquivoToolStripMenuItem.Text = "Abrir Arquivo";
            this.abrirArquivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArquivoToolStripMenuItem_Click);
            // 
            // salvarArquivoToolStripMenuItem
            // 
            this.salvarArquivoToolStripMenuItem.Name = "salvarArquivoToolStripMenuItem";
            this.salvarArquivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarArquivoToolStripMenuItem.Text = "Salvar Arquivo";
            this.salvarArquivoToolStripMenuItem.Click += new System.EventHandler(this.salvarArquivoToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click_1);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refazerToolStripMenuItem.Text = "Refazer";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // opcoesToolStripMenuItem
            // 
            this.opcoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarImpressãoToolStripMenuItem,
            this.visualizarImpressãoToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.alterarTemaToolStripMenuItem});
            this.opcoesToolStripMenuItem.Name = "opcoesToolStripMenuItem";
            this.opcoesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opcoesToolStripMenuItem.Text = "Opções";
            // 
            // configurarImpressãoToolStripMenuItem
            // 
            this.configurarImpressãoToolStripMenuItem.Name = "configurarImpressãoToolStripMenuItem";
            this.configurarImpressãoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.configurarImpressãoToolStripMenuItem.Text = "Configurar Impressão";
            this.configurarImpressãoToolStripMenuItem.Click += new System.EventHandler(this.configurarImpressãoToolStripMenuItem_Click);
            // 
            // visualizarImpressãoToolStripMenuItem
            // 
            this.visualizarImpressãoToolStripMenuItem.Name = "visualizarImpressãoToolStripMenuItem";
            this.visualizarImpressãoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.visualizarImpressãoToolStripMenuItem.Text = "Visualizar Impressão";
            this.visualizarImpressãoToolStripMenuItem.Click += new System.EventHandler(this.visualizarImpressãoToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNewFile,
            this.toolStripOpenFile,
            this.toolStripSaveFile,
            this.toolStripCopy,
            this.toolStripPaste,
            this.toolStripSeparator1,
            this.toolStripBold,
            this.toolStripItalic,
            this.toolStripUnderline,
            this.toolStripFonte,
            this.toolStripCode,
            this.toolStripSeparator2,
            this.toolStripAlingLeft,
            this.toolStripAlingCenter,
            this.toolStripAlingRight,
            this.toolStripSeparator3,
            this.toolStripConfigPrinter,
            this.toolStripPrinter,
            this.toolStripSeparator4,
            this.toolStripSair,
            this.toolStripSeparator5,
            this.toolStripGit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(24, 610);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNewFile
            // 
            this.toolStripNewFile.BackColor = System.Drawing.Color.White;
            this.toolStripNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNewFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNewFile.Image")));
            this.toolStripNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNewFile.Name = "toolStripNewFile";
            this.toolStripNewFile.Size = new System.Drawing.Size(21, 20);
            this.toolStripNewFile.Text = "Novo Arquivo";
            this.toolStripNewFile.Click += new System.EventHandler(this.toolStripNewFile_Click);
            // 
            // toolStripOpenFile
            // 
            this.toolStripOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpenFile.Image")));
            this.toolStripOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpenFile.Name = "toolStripOpenFile";
            this.toolStripOpenFile.Size = new System.Drawing.Size(21, 20);
            this.toolStripOpenFile.Text = "Abrir Arquivo";
            this.toolStripOpenFile.Click += new System.EventHandler(this.toolStripOpenFile_Click);
            // 
            // toolStripSaveFile
            // 
            this.toolStripSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveFile.Image")));
            this.toolStripSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveFile.Name = "toolStripSaveFile";
            this.toolStripSaveFile.Size = new System.Drawing.Size(21, 20);
            this.toolStripSaveFile.Text = "Salvar Arquivo";
            this.toolStripSaveFile.Click += new System.EventHandler(this.toolStripSaveFile_Click);
            // 
            // toolStripCopy
            // 
            this.toolStripCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCopy.Image")));
            this.toolStripCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopy.Name = "toolStripCopy";
            this.toolStripCopy.Size = new System.Drawing.Size(21, 20);
            this.toolStripCopy.Text = "Copiar";
            this.toolStripCopy.Click += new System.EventHandler(this.toolStripCopy_Click_1);
            // 
            // toolStripPaste
            // 
            this.toolStripPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPaste.Image")));
            this.toolStripPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPaste.Name = "toolStripPaste";
            this.toolStripPaste.Size = new System.Drawing.Size(21, 20);
            this.toolStripPaste.Text = "Colar";
            this.toolStripPaste.Click += new System.EventHandler(this.toolStripPaste_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(21, 6);
            // 
            // toolStripBold
            // 
            this.toolStripBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBold.Image")));
            this.toolStripBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBold.Name = "toolStripBold";
            this.toolStripBold.Size = new System.Drawing.Size(21, 20);
            this.toolStripBold.Text = "Negrito";
            this.toolStripBold.Click += new System.EventHandler(this.toolStripBold_Click);
            // 
            // toolStripItalic
            // 
            this.toolStripItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItalic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItalic.Image")));
            this.toolStripItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItalic.Name = "toolStripItalic";
            this.toolStripItalic.Size = new System.Drawing.Size(21, 20);
            this.toolStripItalic.Text = "Itálico ";
            this.toolStripItalic.Click += new System.EventHandler(this.toolStripItalic_Click);
            // 
            // toolStripUnderline
            // 
            this.toolStripUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUnderline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUnderline.Image")));
            this.toolStripUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUnderline.Name = "toolStripUnderline";
            this.toolStripUnderline.Size = new System.Drawing.Size(21, 20);
            this.toolStripUnderline.Text = "Sublinhado";
            this.toolStripUnderline.Click += new System.EventHandler(this.toolStripUnderline_Click);
            // 
            // toolStripFonte
            // 
            this.toolStripFonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripFonte.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFonte.Image")));
            this.toolStripFonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFonte.Name = "toolStripFonte";
            this.toolStripFonte.Size = new System.Drawing.Size(21, 20);
            this.toolStripFonte.Text = "Alterar Fonte";
            this.toolStripFonte.Click += new System.EventHandler(this.toolStripFonte_Click);
            // 
            // toolStripCode
            // 
            this.toolStripCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCode.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCode.Image")));
            this.toolStripCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCode.Name = "toolStripCode";
            this.toolStripCode.Size = new System.Drawing.Size(21, 20);
            this.toolStripCode.Text = "Code";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(21, 6);
            // 
            // toolStripAlingLeft
            // 
            this.toolStripAlingLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAlingLeft.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAlingLeft.Image")));
            this.toolStripAlingLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAlingLeft.Name = "toolStripAlingLeft";
            this.toolStripAlingLeft.Size = new System.Drawing.Size(21, 20);
            this.toolStripAlingLeft.Text = "Alinhar à Esquerda";
            this.toolStripAlingLeft.Click += new System.EventHandler(this.toolStripAlingLeft_Click);
            // 
            // toolStripAlingCenter
            // 
            this.toolStripAlingCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAlingCenter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAlingCenter.Image")));
            this.toolStripAlingCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAlingCenter.Name = "toolStripAlingCenter";
            this.toolStripAlingCenter.Size = new System.Drawing.Size(21, 20);
            this.toolStripAlingCenter.Text = "Centralizar";
            this.toolStripAlingCenter.Click += new System.EventHandler(this.toolStripAlingCenter_Click);
            // 
            // toolStripAlingRight
            // 
            this.toolStripAlingRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAlingRight.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAlingRight.Image")));
            this.toolStripAlingRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAlingRight.Name = "toolStripAlingRight";
            this.toolStripAlingRight.Size = new System.Drawing.Size(21, 20);
            this.toolStripAlingRight.Text = "Alinhar à Direita";
            this.toolStripAlingRight.Click += new System.EventHandler(this.toolStripAlingRight_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(21, 6);
            // 
            // toolStripConfigPrinter
            // 
            this.toolStripConfigPrinter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripConfigPrinter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripConfigPrinter.Image")));
            this.toolStripConfigPrinter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripConfigPrinter.Name = "toolStripConfigPrinter";
            this.toolStripConfigPrinter.Size = new System.Drawing.Size(21, 20);
            this.toolStripConfigPrinter.Text = "Configurar Impressora";
            this.toolStripConfigPrinter.Click += new System.EventHandler(this.toolStripConfigPrinter_Click);
            // 
            // toolStripPrinter
            // 
            this.toolStripPrinter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPrinter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrinter.Image")));
            this.toolStripPrinter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrinter.Name = "toolStripPrinter";
            this.toolStripPrinter.Size = new System.Drawing.Size(21, 20);
            this.toolStripPrinter.Text = "Impressora ";
            this.toolStripPrinter.Click += new System.EventHandler(this.toolStripPrinter_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(21, 6);
            // 
            // toolStripSair
            // 
            this.toolStripSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSair.Image")));
            this.toolStripSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSair.Name = "toolStripSair";
            this.toolStripSair.Size = new System.Drawing.Size(21, 20);
            this.toolStripSair.Text = "Sair";
            this.toolStripSair.Click += new System.EventHandler(this.toolStripSair_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(21, 6);
            // 
            // toolStripGit
            // 
            this.toolStripGit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripGit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGit.Image")));
            this.toolStripGit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGit.Name = "toolStripGit";
            this.toolStripGit.Size = new System.Drawing.Size(21, 20);
            this.toolStripGit.Text = "Meu Github";
            this.toolStripGit.Click += new System.EventHandler(this.toolStripGit_Click);
            // 
            // rtxtb1
            // 
            this.rtxtb1.AcceptsTab = true;
            this.rtxtb1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtb1.Location = new System.Drawing.Point(27, 27);
            this.rtxtb1.Name = "rtxtb1";
            this.rtxtb1.Size = new System.Drawing.Size(850, 600);
            this.rtxtb1.TabIndex = 2;
            this.rtxtb1.Text = "";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "file";
            // 
            // alterarTemaToolStripMenuItem
            // 
            this.alterarTemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escuroToolStripMenuItem,
            this.claroToolStripMenuItem});
            this.alterarTemaToolStripMenuItem.Name = "alterarTemaToolStripMenuItem";
            this.alterarTemaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.alterarTemaToolStripMenuItem.Text = "Alterar Tema";
            this.alterarTemaToolStripMenuItem.Click += new System.EventHandler(this.alterarTemaToolStripMenuItem_Click);
            // 
            // escuroToolStripMenuItem
            // 
            this.escuroToolStripMenuItem.Name = "escuroToolStripMenuItem";
            this.escuroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.escuroToolStripMenuItem.Text = "Escuro";
            this.escuroToolStripMenuItem.Click += new System.EventHandler(this.escutoToolStripMenuItem_Click_1);
            // 
            // claroToolStripMenuItem
            // 
            this.claroToolStripMenuItem.Name = "claroToolStripMenuItem";
            this.claroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.claroToolStripMenuItem.Text = "Claro";
            this.claroToolStripMenuItem.Click += new System.EventHandler(this.claroToolStripMenuItem_Click);
            // 
            // formEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 634);
            this.Controls.Add(this.rtxtb1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Texto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarImpressãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarImpressãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripNewFile;
        private System.Windows.Forms.ToolStripButton toolStripOpenFile;
        private System.Windows.Forms.ToolStripButton toolStripSaveFile;
        private System.Windows.Forms.ToolStripButton toolStripCopy;
        private System.Windows.Forms.ToolStripButton toolStripPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBold;
        private System.Windows.Forms.ToolStripButton toolStripItalic;
        private System.Windows.Forms.ToolStripButton toolStripUnderline;
        private System.Windows.Forms.ToolStripButton toolStripFonte;
        private System.Windows.Forms.ToolStripButton toolStripCode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripAlingLeft;
        private System.Windows.Forms.ToolStripButton toolStripAlingCenter;
        private System.Windows.Forms.ToolStripButton toolStripAlingRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripConfigPrinter;
        private System.Windows.Forms.ToolStripButton toolStripPrinter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripGit;
        private System.Windows.Forms.RichTextBox rtxtb1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem alterarTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem claroToolStripMenuItem;
    }
}

