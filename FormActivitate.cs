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
    public partial class FormActivitate : Form
    {
        // Rezultatul formularului - activitatea creata/editata
        public Activitate ActivitateCreata { get; private set; }
        //Lista de domenii disponibile (primita de la FormPrincipal)
        private List<Domeniu> domenii;

        // Activitatea originala (null = adaugare, not null = editare)
        private Activitate activitateOriginala;

        //constructor adaugare(fara activitate existenta)
        public FormActivitate(List<Domeniu> domenii)
        {
            InitializeComponent();
            this.domenii = domenii;
            this.activitateOriginala = null;
            this.Text = "Adauga activitate noua";
            PopuleazaComboBoxuri();
            // La adaugare, statusul e mereu "Noua" deci il dezactivam
            cbStatus.Enabled = false;
        }
        
        //Constructor editare(cu activitate existenta)
        public FormActivitate(List<Domeniu> domenii, Activitate activitate)
        {
            InitializeComponent();
            this.domenii = domenii;
            this.activitateOriginala = activitate;
            this.Text = "Editeaza activitate";
            PopuleazaComboBoxuri();
            IncarcaDate(activitate);
            //la editare statusul e activ
            cbStatus.Enabled = true;
            
        }

        //Populare COMBOBOX-URI
        private void PopuleazaComboBoxuri()
        {
            //ComboBox domeniu
            cmbDomeniu.Items.Clear();
            foreach(Domeniu d in domenii)
            {
                cmbDomeniu.Items.Add(d.Titlu);
            }
            if (cmbDomeniu.Items.Count > 0)
                cmbDomeniu.SelectedIndex = 0;

            //combobox status
            cbStatus.Items.Clear();
            foreach (StatusActivitate s in Enum.GetValues(typeof(StatusActivitate)))
                cbStatus.Items.Add(s);
            cbStatus.SelectedIndex = 0; // "Noua" default
        }

        //Incarca date(pentru editare)
        private void IncarcaDate(Activitate a)
        {
            tbTitlu.Text=a.Titlu;
            tbLocatie.Text = a.Locatie;
            tbDescriere.Text = a.Descriere;
            dtpDataStart.Value = a.DataStart;
            dtpDataEnd.Value = a.DataEnd;
            nudPrioritate.Value = a.Prioritate;
            //selectam domeniul corect
            for(int i=0;i<cmbDomeniu.Items.Count;i++)
            {
                if (cmbDomeniu.Items[i].ToString() ==a.Domeniu.Titlu)
                {
                    cmbDomeniu.SelectedIndex = i;
                    break;
                }
            }
            //selectam statusul corect
            cbStatus.SelectedIndex=(int)a.Status;
        }
        //Validare date!
        private bool ValideazaFormular()
        {
            bool valid = true;
            //validare titlu
            if(string.IsNullOrWhiteSpace(tbTitlu.Text))
            {
                errorProvider1.SetError(tbTitlu, "Titlul este obligatoriu!");
                valid= false; 
            }
            else
            {
                errorProvider1.SetError(tbTitlu, "");
            }

            // Validare domeniu
            if (cmbDomeniu.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbDomeniu, "Selectati un domeniu!");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(cmbDomeniu, "");
            }

            // Validare date
            if (dtpDataEnd.Value < dtpDataStart.Value)
            {
                errorProvider1.SetError(dtpDataEnd, "Data sfarsit trebuie sa fie dupa data start!");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(dtpDataEnd, "");
            }

            return valid;
        }
        private void lbDataEnd_Click(object sender, EventArgs e)
        {

        }
        private void tbTitlu_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitlu.Text))
            {
                errorProvider1.SetError(tbTitlu, "Titlul este obligatoriu!");
            }
            else
            {
                errorProvider1.SetError(tbTitlu, "");
            }
        }
        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            //validam mai intai
            if(!ValideazaFormular())
            {
                MessageBox.Show("Corectati erorile marcate inainte de salvare.",
                    "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                //gasim domeniul selectat
                string numeDomeniu = cmbDomeniu.SelectedItem.ToString();
                Domeniu domeniu = null;
                foreach(Domeniu d in domenii)
                {
                    if(d.Titlu==numeDomeniu)
                    {
                        domeniu = d;
                        break;
                    }
                }
                // Cream activitatea
                ActivitateCreata = new Activitate(tbTitlu.Text.Trim(), domeniu, dtpDataStart.Value, dtpDataEnd.Value, (int)nudPrioritate.Value, tbDescriere.Text.Trim(), tbLocatie.Text.Trim());
                //Daca este editare,pastram statusul selectat
                if (activitateOriginala != null)
                    ActivitateCreata.Status = (StatusActivitate)cbStatus.SelectedItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }


        private void tbTitlu_Validated(object sender, EventArgs e)
        {

        }

        private void FormActivitate_Load(object sender, EventArgs e)
        {

        }
    }
}
