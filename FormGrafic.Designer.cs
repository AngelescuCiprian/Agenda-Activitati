namespace ProiectPAW
{
    partial class FormGrafic
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
            this.lbTipGrafic = new System.Windows.Forms.Label();
            this.cbTipGrafic = new System.Windows.Forms.ComboBox();
            this.btnSalveazaImagine = new System.Windows.Forms.Button();
            this.panelGrafic = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbTipGrafic
            // 
            this.lbTipGrafic.AutoSize = true;
            this.lbTipGrafic.Location = new System.Drawing.Point(12, 15);
            this.lbTipGrafic.Name = "lbTipGrafic";
            this.lbTipGrafic.Size = new System.Drawing.Size(54, 13);
            this.lbTipGrafic.TabIndex = 0;
            this.lbTipGrafic.Text = "Tip grafic:";
            // 
            // cbTipGrafic
            // 
            this.cbTipGrafic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipGrafic.FormattingEnabled = true;
            this.cbTipGrafic.Items.AddRange(new object[] {
            "Pie Chart - Distributie pe domenii",
            "Bar Chart - Activitati pe prioritate"});
            this.cbTipGrafic.Location = new System.Drawing.Point(78, 12);
            this.cbTipGrafic.Name = "cbTipGrafic";
            this.cbTipGrafic.Size = new System.Drawing.Size(250, 21);
            this.cbTipGrafic.TabIndex = 1;
            this.cbTipGrafic.SelectedIndexChanged += new System.EventHandler(this.cbTipGrafic_SelectedIndexChanged);
            // 
            // btnSalveazaImagine
            // 
            this.btnSalveazaImagine.Location = new System.Drawing.Point(340, 10);
            this.btnSalveazaImagine.Name = "btnSalveazaImagine";
            this.btnSalveazaImagine.Size = new System.Drawing.Size(120, 25);
            this.btnSalveazaImagine.TabIndex = 2;
            this.btnSalveazaImagine.Text = "Salveaza imagine";
            this.btnSalveazaImagine.UseVisualStyleBackColor = true;
            this.btnSalveazaImagine.Click += new System.EventHandler(this.btnSalveazaImagine_Click);
            // 
            // panelGrafic
            // 
            this.panelGrafic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrafic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrafic.Location = new System.Drawing.Point(12, 45);
            this.panelGrafic.Name = "panelGrafic";
            this.panelGrafic.Size = new System.Drawing.Size(560, 375);
            this.panelGrafic.TabIndex = 3;
            this.panelGrafic.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrafic_Paint);
            // 
            // FormGrafic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGrafic);
            this.Controls.Add(this.btnSalveazaImagine);
            this.Controls.Add(this.cbTipGrafic);
            this.Controls.Add(this.lbTipGrafic);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "FormGrafic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vizualizare Grafice- Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTipGrafic;
        private System.Windows.Forms.ComboBox cbTipGrafic;
        private System.Windows.Forms.Button btnSalveazaImagine;
        private System.Windows.Forms.Panel panelGrafic;
    }
}