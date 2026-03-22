namespace ProiectPAW
{
    partial class FormActivitate
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
            this.lbDomeniu = new System.Windows.Forms.Label();
            this.cmbDomeniu = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbDataStart = new System.Windows.Forms.Label();
            this.dtpDataStart = new System.Windows.Forms.DateTimePicker();
            this.lbDataEnd = new System.Windows.Forms.Label();
            this.dtpDataEnd = new System.Windows.Forms.DateTimePicker();
            this.lbPrioritate = new System.Windows.Forms.Label();
            this.nudPrioritate = new System.Windows.Forms.NumericUpDown();
            this.lbLocatie = new System.Windows.Forms.Label();
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.lbDescriere = new System.Windows.Forms.Label();
            this.tbDescriere = new System.Windows.Forms.TextBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrioritate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitlu
            // 
            this.lbTitlu.AutoSize = true;
            this.lbTitlu.Location = new System.Drawing.Point(12, 22);
            this.lbTitlu.Name = "lbTitlu";
            this.lbTitlu.Size = new System.Drawing.Size(30, 13);
            this.lbTitlu.TabIndex = 0;
            this.lbTitlu.Text = "Titlu:";
            // 
            // tbTitlu
            // 
            this.tbTitlu.Location = new System.Drawing.Point(90, 19);
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.Size = new System.Drawing.Size(370, 20);
            this.tbTitlu.TabIndex = 0;
            this.tbTitlu.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitlu_Validating);
            this.tbTitlu.Validated += new System.EventHandler(this.tbTitlu_Validated);
            // 
            // lbDomeniu
            // 
            this.lbDomeniu.AutoSize = true;
            this.lbDomeniu.Location = new System.Drawing.Point(12, 57);
            this.lbDomeniu.Name = "lbDomeniu";
            this.lbDomeniu.Size = new System.Drawing.Size(52, 13);
            this.lbDomeniu.TabIndex = 1;
            this.lbDomeniu.Text = "Domeniu:";
            // 
            // cmbDomeniu
            // 
            this.cmbDomeniu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDomeniu.Location = new System.Drawing.Point(90, 54);
            this.cmbDomeniu.Name = "cmbDomeniu";
            this.cmbDomeniu.Size = new System.Drawing.Size(170, 21);
            this.cmbDomeniu.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(278, 57);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 13);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Location = new System.Drawing.Point(330, 54);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(130, 21);
            this.cbStatus.TabIndex = 2;
            // 
            // lbDataStart
            // 
            this.lbDataStart.AutoSize = true;
            this.lbDataStart.Location = new System.Drawing.Point(12, 95);
            this.lbDataStart.Name = "lbDataStart";
            this.lbDataStart.Size = new System.Drawing.Size(56, 13);
            this.lbDataStart.TabIndex = 3;
            this.lbDataStart.Text = "Data start:";
            // 
            // dtpDataStart
            // 
            this.dtpDataStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataStart.Location = new System.Drawing.Point(90, 91);
            this.dtpDataStart.Name = "dtpDataStart";
            this.dtpDataStart.Size = new System.Drawing.Size(170, 20);
            this.dtpDataStart.TabIndex = 3;
            // 
            // lbDataEnd
            // 
            this.lbDataEnd.AutoSize = true;
            this.lbDataEnd.Location = new System.Drawing.Point(266, 95);
            this.lbDataEnd.Name = "lbDataEnd";
            this.lbDataEnd.Size = new System.Drawing.Size(63, 13);
            this.lbDataEnd.TabIndex = 4;
            this.lbDataEnd.Text = "Data sfarsit:";
            this.lbDataEnd.Click += new System.EventHandler(this.lbDataEnd_Click);
            // 
            // dtpDataEnd
            // 
            this.dtpDataEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEnd.Location = new System.Drawing.Point(330, 91);
            this.dtpDataEnd.Name = "dtpDataEnd";
            this.dtpDataEnd.Size = new System.Drawing.Size(130, 20);
            this.dtpDataEnd.TabIndex = 4;
            // 
            // lbPrioritate
            // 
            this.lbPrioritate.AutoSize = true;
            this.lbPrioritate.Location = new System.Drawing.Point(12, 133);
            this.lbPrioritate.Name = "lbPrioritate";
            this.lbPrioritate.Size = new System.Drawing.Size(51, 13);
            this.lbPrioritate.TabIndex = 5;
            this.lbPrioritate.Text = "Prioritate:";
            // 
            // nudPrioritate
            // 
            this.nudPrioritate.Location = new System.Drawing.Point(90, 131);
            this.nudPrioritate.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPrioritate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrioritate.Name = "nudPrioritate";
            this.nudPrioritate.Size = new System.Drawing.Size(60, 20);
            this.nudPrioritate.TabIndex = 5;
            this.nudPrioritate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbLocatie
            // 
            this.lbLocatie.AutoSize = true;
            this.lbLocatie.Location = new System.Drawing.Point(278, 133);
            this.lbLocatie.Name = "lbLocatie";
            this.lbLocatie.Size = new System.Drawing.Size(45, 13);
            this.lbLocatie.TabIndex = 6;
            this.lbLocatie.Text = "Locatie:";
            // 
            // tbLocatie
            // 
            this.tbLocatie.Location = new System.Drawing.Point(330, 130);
            this.tbLocatie.Name = "tbLocatie";
            this.tbLocatie.Size = new System.Drawing.Size(130, 20);
            this.tbLocatie.TabIndex = 6;
            // 
            // lbDescriere
            // 
            this.lbDescriere.AutoSize = true;
            this.lbDescriere.Location = new System.Drawing.Point(12, 170);
            this.lbDescriere.Name = "lbDescriere";
            this.lbDescriere.Size = new System.Drawing.Size(55, 13);
            this.lbDescriere.TabIndex = 7;
            this.lbDescriere.Text = "Descriere:";
            // 
            // tbDescriere
            // 
            this.tbDescriere.Location = new System.Drawing.Point(90, 167);
            this.tbDescriere.Multiline = true;
            this.tbDescriere.Name = "tbDescriere";
            this.tbDescriere.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescriere.Size = new System.Drawing.Size(370, 80);
            this.tbDescriere.TabIndex = 7;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(304, 265);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(75, 23);
            this.btnSalveaza.TabIndex = 8;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleaza.Location = new System.Drawing.Point(385, 265);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(75, 23);
            this.btnAnuleaza.TabIndex = 9;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormActivitate
            // 
            this.AcceptButton = this.btnSalveaza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(480, 302);
            this.Controls.Add(this.lbTitlu);
            this.Controls.Add(this.tbTitlu);
            this.Controls.Add(this.lbDomeniu);
            this.Controls.Add(this.cmbDomeniu);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbDataStart);
            this.Controls.Add(this.dtpDataStart);
            this.Controls.Add(this.lbDataEnd);
            this.Controls.Add(this.dtpDataEnd);
            this.Controls.Add(this.lbPrioritate);
            this.Controls.Add(this.nudPrioritate);
            this.Controls.Add(this.lbLocatie);
            this.Controls.Add(this.tbLocatie);
            this.Controls.Add(this.lbDescriere);
            this.Controls.Add(this.tbDescriere);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.btnAnuleaza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormActivitate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Activitate";
            this.Load += new System.EventHandler(this.FormActivitate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrioritate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitlu;
        private System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.Label lbDomeniu;
        private System.Windows.Forms.Label lbDataStart;
        private System.Windows.Forms.Label lbPrioritate;
        private System.Windows.Forms.ComboBox cmbDomeniu;
        private System.Windows.Forms.DateTimePicker dtpDataStart;
        private System.Windows.Forms.DateTimePicker dtpDataEnd;
        private System.Windows.Forms.Label lbDataEnd;
        private System.Windows.Forms.NumericUpDown nudPrioritate;
        private System.Windows.Forms.TextBox tbLocatie;
        private System.Windows.Forms.Label lbLocatie;
        private System.Windows.Forms.TextBox tbDescriere;
        private System.Windows.Forms.Label lbDescriere;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
