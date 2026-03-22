namespace ProiectPAW
{
    partial class FormDomeniu
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
            this.lbTitlu = new System.Windows.Forms.Label();
            this.tbTitlu = new System.Windows.Forms.TextBox();
            this.tbDescriere = new System.Windows.Forms.TextBox();
            this.lbDescriere = new System.Windows.Forms.Label();
            this.lbCuloare = new System.Windows.Forms.Label();
            this.cbCuloare = new System.Windows.Forms.ComboBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitlu
            // 
            this.lbTitlu.AutoSize = true;
            this.lbTitlu.Location = new System.Drawing.Point(13, 31);
            this.lbTitlu.Name = "lbTitlu";
            this.lbTitlu.Size = new System.Drawing.Size(27, 13);
            this.lbTitlu.TabIndex = 0;
            this.lbTitlu.Text = "&Titlu";
            // 
            // tbTitlu
            // 
            this.tbTitlu.Location = new System.Drawing.Point(85, 31);
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.Size = new System.Drawing.Size(240, 20);
            this.tbTitlu.TabIndex = 1;
            // 
            // tbDescriere
            // 
            this.tbDescriere.Location = new System.Drawing.Point(85, 57);
            this.tbDescriere.Name = "tbDescriere";
            this.tbDescriere.Size = new System.Drawing.Size(240, 20);
            this.tbDescriere.TabIndex = 3;
            // 
            // lbDescriere
            // 
            this.lbDescriere.AutoSize = true;
            this.lbDescriere.Location = new System.Drawing.Point(13, 57);
            this.lbDescriere.Name = "lbDescriere";
            this.lbDescriere.Size = new System.Drawing.Size(55, 13);
            this.lbDescriere.TabIndex = 2;
            this.lbDescriere.Text = "&Descriere:";
            // 
            // lbCuloare
            // 
            this.lbCuloare.AutoSize = true;
            this.lbCuloare.Location = new System.Drawing.Point(16, 89);
            this.lbCuloare.Name = "lbCuloare";
            this.lbCuloare.Size = new System.Drawing.Size(46, 13);
            this.lbCuloare.TabIndex = 4;
            this.lbCuloare.Text = "&Culoare:";
            // 
            // cbCuloare
            // 
            this.cbCuloare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCuloare.FormattingEnabled = true;
            this.cbCuloare.Items.AddRange(new object[] {
            "Albastru",
            "Rosu",
            "Verde",
            "Galben",
            "Portocaliu",
            "Mov",
            "Gri"});
            this.cbCuloare.Location = new System.Drawing.Point(85, 89);
            this.cbCuloare.Name = "cbCuloare";
            this.cbCuloare.Size = new System.Drawing.Size(240, 21);
            this.cbCuloare.TabIndex = 5;
            this.cbCuloare.SelectedIndex = 0;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(12, 136);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(75, 23);
            this.btnSalveaza.TabIndex = 6;
            this.btnSalveaza.Text = "Sal&veaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleaza.Location = new System.Drawing.Point(106, 136);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(75, 23);
            this.btnAnuleaza.TabIndex = 7;
            this.btnAnuleaza.Text = "A&nuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormDomeniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(364, 211);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.cbCuloare);
            this.Controls.Add(this.lbCuloare);
            this.Controls.Add(this.tbDescriere);
            this.Controls.Add(this.lbDescriere);
            this.Controls.Add(this.tbTitlu);
            this.Controls.Add(this.lbTitlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDomeniu";
            this.Text = "Adauga domeniu nou";
            this.Load += new System.EventHandler(this.FormDomeniu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitlu;
        private System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.TextBox tbDescriere;
        private System.Windows.Forms.Label lbDescriere;
        private System.Windows.Forms.Label lbCuloare;
        private System.Windows.Forms.ComboBox cbCuloare;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}