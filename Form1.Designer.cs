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
            this.activitatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domeniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalveaza = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIncarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportXML = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdaugaActivitate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditeazaActivitate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStergeActivitate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSortPrioritate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSortData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdaugaDomeniu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVizualizeazaDomenii = new System.Windows.Forms.ToolStripMenuItem();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
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
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fisierToolStripMenuItem.Text = "&Fisier";
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
            this.activitatiToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.activitatiToolStripMenuItem.Text = "&Activitati";
            // 
            // domeniiToolStripMenuItem
            // 
            this.domeniiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdaugaDomeniu,
            this.tsmiVizualizeazaDomenii});
            this.domeniiToolStripMenuItem.Name = "domeniiToolStripMenuItem";
            this.domeniiToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.domeniiToolStripMenuItem.Text = "&Domenii";
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDespre});
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.despreToolStripMenuItem.Text = "Des&pre";
            // 
            // tsmiSalveaza
            // 
            this.tsmiSalveaza.Name = "tsmiSalveaza";
            this.tsmiSalveaza.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSalveaza.Size = new System.Drawing.Size(224, 26);
            this.tsmiSalveaza.Text = "&Salveaza";
            this.tsmiSalveaza.Click += new System.EventHandler(this.salveazaToolStripMenuItem_Click);
            // 
            // tsmiIncarca
            // 
            this.tsmiIncarca.Name = "tsmiIncarca";
            this.tsmiIncarca.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiIncarca.Size = new System.Drawing.Size(224, 26);
            this.tsmiIncarca.Text = "&Incarca";
            // 
            // tsmiExportXML
            // 
            this.tsmiExportXML.Name = "tsmiExportXML";
            this.tsmiExportXML.Size = new System.Drawing.Size(224, 26);
            this.tsmiExportXML.Text = "Exporta &XML";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // tsmiIesire
            // 
            this.tsmiIesire.Name = "tsmiIesire";
            this.tsmiIesire.Size = new System.Drawing.Size(224, 26);
            this.tsmiIesire.Text = "I&esire";
            // 
            // tsmiAdaugaActivitate
            // 
            this.tsmiAdaugaActivitate.Name = "tsmiAdaugaActivitate";
            this.tsmiAdaugaActivitate.Size = new System.Drawing.Size(254, 26);
            this.tsmiAdaugaActivitate.Text = "&Adauga activitate";
            // 
            // tsmiEditeazaActivitate
            // 
            this.tsmiEditeazaActivitate.Name = "tsmiEditeazaActivitate";
            this.tsmiEditeazaActivitate.Size = new System.Drawing.Size(254, 26);
            this.tsmiEditeazaActivitate.Text = "&Editeaza activitate";
            // 
            // tsmiStergeActivitate
            // 
            this.tsmiStergeActivitate.Name = "tsmiStergeActivitate";
            this.tsmiStergeActivitate.Size = new System.Drawing.Size(254, 26);
            this.tsmiStergeActivitate.Text = "&Sterge activitate";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(251, 6);
            // 
            // tsmiSortPrioritate
            // 
            this.tsmiSortPrioritate.Name = "tsmiSortPrioritate";
            this.tsmiSortPrioritate.Size = new System.Drawing.Size(254, 26);
            this.tsmiSortPrioritate.Text = "Sorteaza dupa &prioritate";
            // 
            // tsmiSortData
            // 
            this.tsmiSortData.Name = "tsmiSortData";
            this.tsmiSortData.Size = new System.Drawing.Size(254, 26);
            this.tsmiSortData.Text = "Sorteaza dupa &data";
            // 
            // tsmiAdaugaDomeniu
            // 
            this.tsmiAdaugaDomeniu.Name = "tsmiAdaugaDomeniu";
            this.tsmiAdaugaDomeniu.Size = new System.Drawing.Size(224, 26);
            this.tsmiAdaugaDomeniu.Text = "Adauga &domeniu";
            // 
            // tsmiVizualizeazaDomenii
            // 
            this.tsmiVizualizeazaDomenii.Name = "tsmiVizualizeazaDomenii";
            this.tsmiVizualizeazaDomenii.Size = new System.Drawing.Size(224, 26);
            this.tsmiVizualizeazaDomenii.Text = "&Vizualizeaza";
            // 
            // tsmiDespre
            // 
            this.tsmiDespre.Name = "tsmiDespre";
            this.tsmiDespre.Size = new System.Drawing.Size(224, 26);
            this.tsmiDespre.Text = "Despre &aplicatie";
            // 
            // lbFiltruDomeniu
            // 
            this.lbFiltruDomeniu.AutoSize = true;
            this.lbFiltruDomeniu.Location = new System.Drawing.Point(15, 35);
            this.lbFiltruDomeniu.Name = "lbFiltruDomeniu";
            this.lbFiltruDomeniu.Size = new System.Drawing.Size(64, 16);
            this.lbFiltruDomeniu.TabIndex = 1;
            this.lbFiltruDomeniu.Text = "Domeniu:";
            // 
            // cbFiltruDomeniu
            // 
            this.cbFiltruDomeniu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltruDomeniu.FormattingEnabled = true;
            this.cbFiltruDomeniu.Location = new System.Drawing.Point(133, 35);
            this.cbFiltruDomeniu.Name = "cbFiltruDomeniu";
            this.cbFiltruDomeniu.Size = new System.Drawing.Size(180, 24);
            this.cbFiltruDomeniu.TabIndex = 2;
            // 
            // lbFiltruStatus
            // 
            this.lbFiltruStatus.AutoSize = true;
            this.lbFiltruStatus.Location = new System.Drawing.Point(328, 38);
            this.lbFiltruStatus.Name = "lbFiltruStatus";
            this.lbFiltruStatus.Size = new System.Drawing.Size(47, 16);
            this.lbFiltruStatus.TabIndex = 3;
            this.lbFiltruStatus.Text = "Status:";
            // 
            // cbFiltruStatus
            // 
            this.cbFiltruStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltruStatus.FormattingEnabled = true;
            this.cbFiltruStatus.Location = new System.Drawing.Point(381, 35);
            this.cbFiltruStatus.Name = "cbFiltruStatus";
            this.cbFiltruStatus.Size = new System.Drawing.Size(150, 24);
            this.cbFiltruStatus.TabIndex = 4;
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
            this.lvActivitati.FullRowSelect = true;
            this.lvActivitati.GridLines = true;
            this.lvActivitati.HideSelection = false;
            this.lvActivitati.Location = new System.Drawing.Point(0, 105);
            this.lvActivitati.MultiSelect = false;
            this.lvActivitati.Name = "lvActivitati";
            this.lvActivitati.Size = new System.Drawing.Size(538, 161);
            this.lvActivitati.TabIndex = 5;
            this.lvActivitati.UseCompatibleStateImageBehavior = false;
            this.lvActivitati.View = System.Windows.Forms.View.Details;
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
            this.contextMenuActivitati.Size = new System.Drawing.Size(216, 130);
            // 
            // ctxEditeaza
            // 
            this.ctxEditeaza.Name = "ctxEditeaza";
            this.ctxEditeaza.Size = new System.Drawing.Size(215, 24);
            this.ctxEditeaza.Text = "Editeaza";
            // 
            // ctxSterge
            // 
            this.ctxSterge.Name = "ctxSterge";
            this.ctxSterge.Size = new System.Drawing.Size(215, 24);
            this.ctxSterge.Text = "Sterge";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(212, 6);
            // 
            // ctxMarcheazaFinalizata
            // 
            this.ctxMarcheazaFinalizata.Name = "ctxMarcheazaFinalizata";
            this.ctxMarcheazaFinalizata.Size = new System.Drawing.Size(215, 24);
            this.ctxMarcheazaFinalizata.Text = "Marcheaza finalizata";
            // 
            // ctxCrestePrioritate
            // 
            this.ctxCrestePrioritate.Name = "ctxCrestePrioritate";
            this.ctxCrestePrioritate.Size = new System.Drawing.Size(215, 24);
            this.ctxCrestePrioritate.Text = "Creste prioritatea";
            // 
            // ctxScadePrioritate
            // 
            this.ctxScadePrioritate.Name = "ctxScadePrioritate";
            this.ctxScadePrioritate.Size = new System.Drawing.Size(215, 24);
            this.ctxScadePrioritate.Text = "Scade prioritatea";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 32);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.lvActivitati);
            this.Controls.Add(this.cbFiltruStatus);
            this.Controls.Add(this.lbFiltruStatus);
            this.Controls.Add(this.cbFiltruDomeniu);
            this.Controls.Add(this.lbFiltruDomeniu);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Activitati";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}