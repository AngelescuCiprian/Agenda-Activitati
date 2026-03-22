namespace ProiectPAW
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalveaza = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIncarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportXML = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.activitatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdaugaActivitate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditeazaActivitate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStergeActivitate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSortPrioritate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSortData = new System.Windows.Forms.ToolStripMenuItem();
            this.domeniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdaugaDomeniu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVizualizeazaDomenii = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDespre = new System.Windows.Forms.ToolStripMenuItem();
            this.lbFiltruDomeniu = new System.Windows.Forms.Label();
            this.cbFiltruDomeniu = new System.Windows.Forms.ComboBox();
            this.lbFiltruStatus = new System.Windows.Forms.Label();
            this.cbFiltruStatus = new System.Windows.Forms.ComboBox();
            this.lvActivitati = new System.Windows.Forms.ListView();
            this.colTitlu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDomeniu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrioritate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLocatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuActivitati = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxEditeaza = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSterge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxMarcheazaFinalizata = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCrestePrioritate = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxScadePrioritate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.StatusStrip();
            this.tsslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.contextMenuActivitati.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.activitatiToolStripMenuItem,
            this.domeniiToolStripMenuItem,
            this.despreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSalveaza,
            this.tsmiIncarca,
            this.tsmiExportXML,
            this.toolStripMenuItem1,
            this.tsmiIesire});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fisierToolStripMenuItem.Text = "&Fisier";
            // 
            // tsmiSalveaza
            // 
            this.tsmiSalveaza.Name = "tsmiSalveaza";
            this.tsmiSalveaza.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSalveaza.Size = new System.Drawing.Size(158, 22);
            this.tsmiSalveaza.Text = "&Salveaza";
            this.tsmiSalveaza.Click += new System.EventHandler(this.salveazaToolStripMenuItem_Click);
            // 
            // tsmiIncarca
            // 
            this.tsmiIncarca.Name = "tsmiIncarca";
            this.tsmiIncarca.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiIncarca.Size = new System.Drawing.Size(180, 22);
            this.tsmiIncarca.Text = "&Incarca";
            this.tsmiIncarca.Click += new System.EventHandler(this.tsmiIncarca_Click);
            // 
            // tsmiExportXML
            // 
            this.tsmiExportXML.Name = "tsmiExportXML";
            this.tsmiExportXML.Size = new System.Drawing.Size(180, 22);
            this.tsmiExportXML.Text = "Exporta &XML";
            this.tsmiExportXML.Click += new System.EventHandler(this.tsmiExportXML_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmiIesire
            // 
            this.tsmiIesire.Name = "tsmiIesire";
            this.tsmiIesire.Size = new System.Drawing.Size(180, 22);
            this.tsmiIesire.Text = "I&esire";
            this.tsmiIesire.Click += new System.EventHandler(this.tsmiIesire_Click);
            // 
            // activitatiToolStripMenuItem
            // 
            this.activitatiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdaugaActivitate,
            this.tsmiEditeazaActivitate,
            this.tsmiStergeActivitate,
            this.toolStripMenuItem2,
            this.tsmiSortPrioritate,
            this.tsmiSortData});
            this.activitatiToolStripMenuItem.Name = "activitatiToolStripMenuItem";
            this.activitatiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.activitatiToolStripMenuItem.Text = "&Activitati";
            // 
            // tsmiAdaugaActivitate
            // 
            this.tsmiAdaugaActivitate.Name = "tsmiAdaugaActivitate";
            this.tsmiAdaugaActivitate.Size = new System.Drawing.Size(199, 22);
            this.tsmiAdaugaActivitate.Text = "&Adauga activitate";
            this.tsmiAdaugaActivitate.Click += new System.EventHandler(this.tsmiAdaugaActivitate_Click);
            // 
            // tsmiEditeazaActivitate
            // 
            this.tsmiEditeazaActivitate.Name = "tsmiEditeazaActivitate";
            this.tsmiEditeazaActivitate.Size = new System.Drawing.Size(199, 22);
            this.tsmiEditeazaActivitate.Text = "&Editeaza activitate";
            this.tsmiEditeazaActivitate.Click += new System.EventHandler(this.tsmiEditeazaActivitate_Click);
            // 
            // tsmiStergeActivitate
            // 
            this.tsmiStergeActivitate.Name = "tsmiStergeActivitate";
            this.tsmiStergeActivitate.Size = new System.Drawing.Size(199, 22);
            this.tsmiStergeActivitate.Text = "&Sterge activitate";
            this.tsmiStergeActivitate.Click += new System.EventHandler(this.tsmiStergeActivitate_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(196, 6);
            // 
            // tsmiSortPrioritate
            // 
            this.tsmiSortPrioritate.Name = "tsmiSortPrioritate";
            this.tsmiSortPrioritate.Size = new System.Drawing.Size(199, 22);
            this.tsmiSortPrioritate.Text = "Sorteaza dupa &prioritate";
            this.tsmiSortPrioritate.Click += new System.EventHandler(this.tsmiSortPrioritate_Click);
            // 
            // tsmiSortData
            // 
            this.tsmiSortData.Name = "tsmiSortData";
            this.tsmiSortData.Size = new System.Drawing.Size(199, 22);
            this.tsmiSortData.Text = "Sorteaza dupa &data";
            this.tsmiSortData.Click += new System.EventHandler(this.tsmiSortData_Click);
            // 
            // domeniiToolStripMenuItem
            // 
            this.domeniiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdaugaDomeniu,
            this.tsmiVizualizeazaDomenii});
            this.domeniiToolStripMenuItem.Name = "domeniiToolStripMenuItem";
            this.domeniiToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.domeniiToolStripMenuItem.Text = "&Domenii";
            // 
            // tsmiAdaugaDomeniu
            // 
            this.tsmiAdaugaDomeniu.Name = "tsmiAdaugaDomeniu";
            this.tsmiAdaugaDomeniu.Size = new System.Drawing.Size(180, 22);
            this.tsmiAdaugaDomeniu.Text = "Adauga &domeniu";
            this.tsmiAdaugaDomeniu.Click += new System.EventHandler(this.tsmiAdaugaDomeniu_Click);
            // 
            // tsmiVizualizeazaDomenii
            // 
            this.tsmiVizualizeazaDomenii.Name = "tsmiVizualizeazaDomenii";
            this.tsmiVizualizeazaDomenii.Size = new System.Drawing.Size(180, 22);
            this.tsmiVizualizeazaDomenii.Text = "&Vizualizeaza";
            this.tsmiVizualizeazaDomenii.Click += new System.EventHandler(this.tsmiVizualizeazaDomenii_Click);
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDespre});
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.despreToolStripMenuItem.Text = "Des&pre";
            // 
            // tsmiDespre
            // 
            this.tsmiDespre.Name = "tsmiDespre";
            this.tsmiDespre.Size = new System.Drawing.Size(180, 22);
            this.tsmiDespre.Text = "Despre &aplicatie";
            this.tsmiDespre.Click += new System.EventHandler(this.tsmiDespre_Click);
            // 
            // lbFiltruDomeniu
            // 
            this.lbFiltruDomeniu.AutoSize = true;
            this.lbFiltruDomeniu.Location = new System.Drawing.Point(11, 28);
            this.lbFiltruDomeniu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFiltruDomeniu.Name = "lbFiltruDomeniu";
            this.lbFiltruDomeniu.Size = new System.Drawing.Size(52, 13);
            this.lbFiltruDomeniu.TabIndex = 1;
            this.lbFiltruDomeniu.Text = "Domeniu:";
            // 
            // cbFiltruDomeniu
            // 
            this.cbFiltruDomeniu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltruDomeniu.FormattingEnabled = true;
            this.cbFiltruDomeniu.Location = new System.Drawing.Point(100, 28);
            this.cbFiltruDomeniu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFiltruDomeniu.Name = "cbFiltruDomeniu";
            this.cbFiltruDomeniu.Size = new System.Drawing.Size(136, 21);
            this.cbFiltruDomeniu.TabIndex = 2;
            this.cbFiltruDomeniu.SelectedIndexChanged += new System.EventHandler(this.cbFiltruDomeniu_SelectedIndexChanged);
            // 
            // lbFiltruStatus
            // 
            this.lbFiltruStatus.AutoSize = true;
            this.lbFiltruStatus.Location = new System.Drawing.Point(246, 31);
            this.lbFiltruStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFiltruStatus.Name = "lbFiltruStatus";
            this.lbFiltruStatus.Size = new System.Drawing.Size(40, 13);
            this.lbFiltruStatus.TabIndex = 3;
            this.lbFiltruStatus.Text = "Status:";
            // 
            // cbFiltruStatus
            // 
            this.cbFiltruStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltruStatus.FormattingEnabled = true;
            this.cbFiltruStatus.Location = new System.Drawing.Point(286, 28);
            this.cbFiltruStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFiltruStatus.Name = "cbFiltruStatus";
            this.cbFiltruStatus.Size = new System.Drawing.Size(114, 21);
            this.cbFiltruStatus.TabIndex = 4;
            this.cbFiltruStatus.SelectedIndexChanged += new System.EventHandler(this.cbFiltruStatus_SelectedIndexChanged);
            // 
            // lvActivitati
            // 
            this.lvActivitati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvActivitati.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitlu,
            this.colDomeniu,
            this.colDataStart,
            this.colDataEnd,
            this.colPrioritate,
            this.colStatus,
            this.colLocatie});
            this.lvActivitati.ContextMenuStrip = this.contextMenuActivitati;
            this.lvActivitati.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvActivitati.FullRowSelect = true;
            this.lvActivitati.GridLines = true;
            this.lvActivitati.HideSelection = false;
            this.lvActivitati.Location = new System.Drawing.Point(0, 79);
            this.lvActivitati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvActivitati.MultiSelect = false;
            this.lvActivitati.Name = "lvActivitati";
            this.lvActivitati.Size = new System.Drawing.Size(406, 132);
            this.lvActivitati.TabIndex = 5;
            this.lvActivitati.UseCompatibleStateImageBehavior = false;
            this.lvActivitati.View = System.Windows.Forms.View.Details;
            this.lvActivitati.SelectedIndexChanged += new System.EventHandler(this.lvActivitati_SelectedIndexChanged);
            this.lvActivitati.DoubleClick += new System.EventHandler(this.lvActivitati_DoubleClick);
            // 
            // colTitlu
            // 
            this.colTitlu.Text = "Titlu";
            this.colTitlu.Width = 150;
            // 
            // colDomeniu
            // 
            this.colDomeniu.Text = "Domeniu";
            this.colDomeniu.Width = 150;
            // 
            // colDataStart
            // 
            this.colDataStart.Text = "Data Start";
            this.colDataStart.Width = 90;
            // 
            // colDataEnd
            // 
            this.colDataEnd.Text = "Data End";
            this.colDataEnd.Width = 90;
            // 
            // colPrioritate
            // 
            this.colPrioritate.Text = "P";
            this.colPrioritate.Width = 40;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 80;
            // 
            // colLocatie
            // 
            this.colLocatie.Text = "Locatie";
            this.colLocatie.Width = 100;
            // 
            // contextMenuActivitati
            // 
            this.contextMenuActivitati.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuActivitati.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxEditeaza,
            this.ctxSterge,
            this.toolStripMenuItem3,
            this.ctxMarcheazaFinalizata,
            this.ctxCrestePrioritate,
            this.ctxScadePrioritate});
            this.contextMenuActivitati.Name = "contextMenuActivitati";
            this.contextMenuActivitati.Size = new System.Drawing.Size(182, 120);
            // 
            // ctxEditeaza
            // 
            this.ctxEditeaza.Name = "ctxEditeaza";
            this.ctxEditeaza.Size = new System.Drawing.Size(181, 22);
            this.ctxEditeaza.Text = "Editeaza";
            this.ctxEditeaza.Click += new System.EventHandler(this.ctxEditeaza_Click);
            // 
            // ctxSterge
            // 
            this.ctxSterge.Name = "ctxSterge";
            this.ctxSterge.Size = new System.Drawing.Size(181, 22);
            this.ctxSterge.Text = "Sterge";
            this.ctxSterge.Click += new System.EventHandler(this.ctxSterge_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(178, 6);
            // 
            // ctxMarcheazaFinalizata
            // 
            this.ctxMarcheazaFinalizata.Name = "ctxMarcheazaFinalizata";
            this.ctxMarcheazaFinalizata.Size = new System.Drawing.Size(181, 22);
            this.ctxMarcheazaFinalizata.Text = "Marcheaza finalizata";
            this.ctxMarcheazaFinalizata.Click += new System.EventHandler(this.ctxMarcheazaFinalizata_Click);
            // 
            // ctxCrestePrioritate
            // 
            this.ctxCrestePrioritate.Name = "ctxCrestePrioritate";
            this.ctxCrestePrioritate.Size = new System.Drawing.Size(181, 22);
            this.ctxCrestePrioritate.Text = "Creste prioritatea";
            this.ctxCrestePrioritate.Click += new System.EventHandler(this.ctxCrestePrioritate_Click);
            // 
            // ctxScadePrioritate
            // 
            this.ctxScadePrioritate.Name = "ctxScadePrioritate";
            this.ctxScadePrioritate.Size = new System.Drawing.Size(181, 22);
            this.ctxScadePrioritate.Text = "Scade prioritatea";
            this.ctxScadePrioritate.Click += new System.EventHandler(this.ctxScadePrioritate_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdauga.Location = new System.Drawing.Point(33, 247);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(110, 35);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "&Adauga";
            this.btnAdauga.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnAdauga.ForeColor = System.Drawing.Color.White;
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditeaza.Location = new System.Drawing.Point(149, 247);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(110, 35);
            this.btnEditeaza.TabIndex = 7;
            this.btnEditeaza.Text = "&Editeaza";
            this.btnEditeaza.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnEditeaza.ForeColor = System.Drawing.Color.White;
            this.btnEditeaza.UseVisualStyleBackColor = false;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSterge.Location = new System.Drawing.Point(265, 247);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(110, 35);
            this.btnSterge.TabIndex = 8;
            this.btnSterge.Text = "&Sterge";
            this.btnSterge.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.btnSterge.ForeColor = System.Drawing.Color.White;
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalveaza.Location = new System.Drawing.Point(381, 247);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(110, 35);
            this.btnSalveaza.TabIndex = 9;
            this.btnSalveaza.Text = "Sa&lveaza";
            this.btnSalveaza.BackColor = System.Drawing.Color.FromArgb(96, 125, 139);
            this.btnSalveaza.ForeColor = System.Drawing.Color.White;
            this.btnSalveaza.UseVisualStyleBackColor = false;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // lblStatus
            // 
            this.tsslInfo.Name = "tsslInfo";
            this.tsslInfo.Text = "Pregatit";
            //
            // lblStatus
            //
            this.lblStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.tsslInfo });
            this.lblStatus.Location = new System.Drawing.Point(0, 346);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(588, 22);
            this.lblStatus.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 368);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnEditeaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lvActivitati);
            this.Controls.Add(this.cbFiltruStatus);
            this.Controls.Add(this.lbFiltruStatus);
            this.Controls.Add(this.cbFiltruDomeniu);
            this.Controls.Add(this.lbFiltruDomeniu);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Text = "Agenda de Activitati";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuActivitati.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domeniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalveaza;
        private System.Windows.Forms.ToolStripMenuItem tsmiIncarca;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportXML;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiIesire;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdaugaActivitate;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditeazaActivitate;
        private System.Windows.Forms.ToolStripMenuItem tsmiStergeActivitate;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortPrioritate;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortData;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdaugaDomeniu;
        private System.Windows.Forms.ToolStripMenuItem tsmiVizualizeazaDomenii;
        private System.Windows.Forms.ToolStripMenuItem tsmiDespre;
        private System.Windows.Forms.Label lbFiltruDomeniu;
        private System.Windows.Forms.ComboBox cbFiltruDomeniu;
        private System.Windows.Forms.Label lbFiltruStatus;
        private System.Windows.Forms.ComboBox cbFiltruStatus;
        private System.Windows.Forms.ListView lvActivitati;
        private System.Windows.Forms.ColumnHeader colTitlu;
        private System.Windows.Forms.ColumnHeader colDomeniu;
        private System.Windows.Forms.ColumnHeader colDataStart;
        private System.Windows.Forms.ColumnHeader colDataEnd;
        private System.Windows.Forms.ColumnHeader colPrioritate;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colLocatie;
        private System.Windows.Forms.ContextMenuStrip contextMenuActivitati;
        private System.Windows.Forms.ToolStripMenuItem ctxEditeaza;
        private System.Windows.Forms.ToolStripMenuItem ctxSterge;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ctxMarcheazaFinalizata;
        private System.Windows.Forms.ToolStripMenuItem ctxCrestePrioritate;
        private System.Windows.Forms.ToolStripMenuItem ctxScadePrioritate;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnEditeaza;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.StatusStrip lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslInfo;
    }
}