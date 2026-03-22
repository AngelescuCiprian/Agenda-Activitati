using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class FormDomeniu : Form
    {
        //Rezultatul-domeniul creat
        public Domeniu DomeniuCreat { get; private set; }
        public FormDomeniu()
        {
            InitializeComponent();
        }

        //Dublu-click pe btnSalveaza in Designer
        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            //validare
            if(string.IsNullOrWhiteSpace(tbTitlu.Text))
            {
                errorProvider1.SetError(tbTitlu, "Titlul este obligatoriu!");
                    return;
            }
            try
            {
                DomeniuCreat = new Domeniu(tbTitlu.Text.Trim(), tbDescriere.Text.Trim(), cbCuloare.SelectedItem.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDomeniu_Load(object sender, EventArgs e)
        {

        }
    }
}
