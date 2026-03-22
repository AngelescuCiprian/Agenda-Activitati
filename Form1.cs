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
    public partial class Form1: Form
    {
        private AgendaActivitati agenda;
        public Form1()
        {
            InitializeComponent();
            agenda = new AgendaActivitati();
            //abonam la event-ul din AgendaActivitati(delegate)
            agenda.NotificareModificare += new AgendaEventHandler(AgendaModificata);
            AdaugaDateImplicite();
        }
        //date implicite(pentru testare)
        private void AdaugaDateImplicite()
        {
            agenda.AdaugaDomeniu(new Domeniu("Facultate", "Cursuri si laboratoare", "Albastru"));
            agenda.AdaugaDomeniu(new Domeniu("Munca", "Activitati profesionale", "Rosu"));
            agenda.AdaugaDomeniu(new Domeniu("Personal", "Activitati personale", "Verde"));

            agenda.AdaugaActivitate(new Activitate(
                "Proiect C#", agenda.GasesteDomeniu("Facultate"),
                DateTime.Now, DateTime.Now.AddDays(21), 4,
                "Realizare proiect semestrial", "Acasa"));

            agenda.AdaugaActivitate(new Activitate(
                "Examen SGBD", agenda.GasesteDomeniu("Facultate"),
                DateTime.Now.AddDays(10), DateTime.Now.AddDays(30), 5,
                "Pregatire examen Baze de Date"));

            agenda.AdaugaActivitate(new Activitate(
                "Raport lunar", agenda.GasesteDomeniu("Munca"),
                DateTime.Now, DateTime.Now.AddDays(3), 3,
                "Pregatire raport activitate lunara"));
        }

        //metode de refresh(actualizare interfata)
        private void RefreshListView()
        {
            lvActivitati.Items.Clear();
            //determinam lista de afisat(cu sau fara filtru)
            List<Activitate> deAfisat = new List<Activitate>(agenda.Activitati);
            //filtru domeniu
            if(cbFiltruDomeniu.SelectedIndex>0) //0=Toate
            {
                string domeniuSelectat = cbFiltruDomeniu.SelectedItem.ToString();
                Domeniu d = agenda.GasesteDomeniu(domeniuSelectat);
                if (d != null)
                    deAfisat = agenda.FiltreazaDupaDomeniu(d);
            }
            //filtru status
            if(cbFiltruStatus.SelectedIndex>0)
            {
                StatusActivitate statusSelectat = (StatusActivitate)cbFiltruStatus.SelectedItem;
                deAfisat = deAfisat.Where(a => a.Status == statusSelectat).ToList();
            }
            //adaugam elementele in ListView
            foreach(Activitate a in deAfisat)
            {
                ListViewItem item = new ListViewItem(a.Titlu);
                item.SubItems.Add(a.Domeniu.Titlu);
                item.SubItems.Add(a.DataStart.ToString("dd.MM.yyyy"));
                item.SubItems.Add(a.DataEnd.ToString("dd.MM.yyyy"));
                item.SubItems.Add(a.Prioritate.ToString());
                item.SubItems.Add(a.Status.ToString());
                item.SubItems.Add(a.Locatie);

                //coloram fundalul in functie de status/urgenta
                if (a.EsteUrgenta())
                    item.BackColor = Color.LightCoral;
                else if (a.Status == StatusActivitate.Finalizata)
                    item.BackColor = Color.LightGreen;
                else if (a.Status == StatusActivitate.InProgres)
                    item.BackColor = Color.LightYellow;
                else if (a.Status == StatusActivitate.Anulata)
                    item.BackColor = Color.LightGray;

                //coloram textul coloanei Domeniu dupa culoarea domeniului
                item.UseItemStyleForSubItems = false;
                item.SubItems[1].ForeColor = GetCuloareDomeniu(a.Domeniu.Culoare);

                //pastram id-ul in tag
                item.Tag = a.Id;
                lvActivitati.Items.Add(item);
            }
            ActualizeazaStatusBar();
        }

        private void RefreshComboBoxDomenii()
        {
            cbFiltruDomeniu.Items.Clear();
            cbFiltruDomeniu.Items.Add("Toate");
            foreach (Domeniu d in agenda.Domenii)
                cbFiltruDomeniu.Items.Add(d.Titlu);
            cbFiltruDomeniu.SelectedIndex = 0;

            //populam si comboboxul de status(doar prima data)
            if(cbFiltruStatus.Items.Count==0)
            {
                cbFiltruStatus.Items.Add("Toate");
                foreach (StatusActivitate s in Enum.GetValues(typeof(StatusActivitate)))
                    cbFiltruStatus.Items.Add(s);
                cbFiltruStatus.SelectedIndex = 0;
            }
        }
        private void ActualizeazaStatusBar()
        {
            tsslInfo.Text = $"Activitati: {agenda.TotalActivitati} | " +
                            $"Domenii: {agenda.Domenii.Count} | " +
                            $"Proiecte: {agenda.TotalProiecte}";
        }
        //returneaza activitatea selectata in ListView
        private Activitate GetActivitateSelectata()
        {
            if (lvActivitati.SelectedItems.Count == 0) return null;
            int id = (int)lvActivitati.SelectedItems[0].Tag;
            return agenda.GasesteActivitate(id);
        }

        //handler pt eventul din AgendaActivitati(delegate!)
        private void AgendaModificata(object sender, AgendaEventArgs e)
        {
            ActualizeazaStatusBar();
        }

        //FORM EVENTS
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            RefreshComboBoxDomenii();
            RefreshListView();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode==Keys.N) //CTRL + N=activitate noua
            {
                btnAdauga_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete)       // Delete = sterge
            {
                btnSterge_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F2)            // F2 = editeaza
            {
                btnEditeaza_Click(sender, e);
                e.Handled = true;
            }
        }

        //Butoane
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                FormActivitate form = new FormActivitate(agenda.Domenii);
                if(form.ShowDialog()==DialogResult.OK)
                {
                    agenda.AdaugaActivitate(form.ActivitateCreata);
                    RefreshListView();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Eroare la adaugare: " + ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            try
            {
                Activitate selectata = GetActivitateSelectata();
                if(selectata==null)
                {
                    MessageBox.Show("Selectati o activitate din lista.", "Atentie",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                FormActivitate form = new FormActivitate(agenda.Domenii, selectata);
                if(form.ShowDialog()==DialogResult.OK)
                {
                    selectata.Titlu = form.ActivitateCreata.Titlu;
                    selectata.Domeniu = form.ActivitateCreata.Domeniu;
                    selectata.DataStart = form.ActivitateCreata.DataStart;
                    selectata.DataEnd = form.ActivitateCreata.DataEnd;
                    selectata.Prioritate = form.ActivitateCreata.Prioritate;
                    selectata.Locatie = form.ActivitateCreata.Locatie;
                    selectata.Descriere = form.ActivitateCreata.Descriere;
                    selectata.Status = form.ActivitateCreata.Status;

                    RefreshListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la editare: " + ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            try
            {
                Activitate selectata = GetActivitateSelectata();
                if(selectata==null)
                {
                    MessageBox.Show("Selectati o activitate din lista.", "Atentie",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult confirmare = MessageBox.Show(
                    $"Sigur doriti sa stergeti activitatea '{selectata.Titlu}'?",
                    "Confirmare stergere",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(confirmare==DialogResult.Yes)
                {
                    agenda.StergeActivitate(selectata.Id);
                    RefreshListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la stergere: " + ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            salveazaToolStripMenuItem_Click(sender, e);
        }

        //Meniu Principal

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter= "Fisiere text (*.txt)|*.txt|Toate fisierele (*.*)|*.*";
                sfd.FileName = "agenda.txt";
                if(sfd.ShowDialog()==DialogResult.OK)
                {
                    agenda.SalveazaInFisier(sfd.FileName);
                    MessageBox.Show("Agenda a fost salvata cu succes!", "Salvare",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiIncarca_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter= ofd.Filter = "Fisiere text (*.txt)|*.txt|Toate fisierele (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    agenda.RestaureazaDinFisier(ofd.FileName);
                    RefreshComboBoxDomenii();
                    RefreshListView();
                    MessageBox.Show("Agenda a fost incarcata cu succes!", "Incarcare",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch( Exception ex)
            {
                MessageBox.Show("Eroare la incarcare: " + ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiExportXML_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Fisiere XML (*.xml)|*.xml|Toate fisierele (*.*)|*.*";
                sfd.FileName = "agenda.xml";
                if(sfd.ShowDialog()==DialogResult.OK)
                {
                    agenda.SalveazaInFisierXML(sfd.FileName);
                    MessageBox.Show("Agenda a fost exportata in XML!", "Export",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Eroare la export: " + ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tsmiAdaugaActivitate_Click(object sender, EventArgs e)
        {
            btnAdauga_Click(sender, e);
        }

        private void tsmiEditeazaActivitate_Click(object sender, EventArgs e)
        {
            btnEditeaza_Click(sender, e);
        }

        private void tsmiStergeActivitate_Click(object sender, EventArgs e)
        {
            btnSterge_Click(sender, e);
        }

        private void tsmiSortPrioritate_Click(object sender, EventArgs e)
        {
            List<Activitate> sortate = agenda.SorteazaActivitateDupaPrioritate();
            agenda.Activitati.Clear();
            agenda.Activitati.AddRange(sortate);
            RefreshListView();
        }

        private void tsmiSortData_Click(object sender, EventArgs e)
        {
            List<Activitate> sortate = agenda.SorteazaActivitateDupaData();
            agenda.Activitati.Clear();
            agenda.Activitati.AddRange(sortate);
            RefreshListView();
        }

        private void tsmiAdaugaDomeniu_Click(object sender, EventArgs e)
        {
           try
            {
                FormDomeniu form = new FormDomeniu();
                if(form.ShowDialog()==DialogResult.OK)
                {
                    agenda.AdaugaDomeniu(form.DomeniuCreat);
                    RefreshComboBoxDomenii();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiVizualizeazaDomenii_Click(object sender, EventArgs e)
        {
            string lista = "Domenii existente:\n\n";
            foreach(Domeniu d in agenda.Domenii)
                lista += $"  - {d.Titlu} (culoare: {d.Culoare})\n";
            MessageBox.Show(lista, "Domenii", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmiDespre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Agenda de Activitati\nProiect PAW - 2025/2026\n\n" +
                "Aplicatie pentru gestionarea activitatilor,\nproiectelor si domeniilor.",
                "Despre aplicatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        //Meniu contextual

        private void ctxEditeaza_Click(object sender, EventArgs e)
        {
            btnEditeaza_Click(sender, e);
        }

        private void ctxSterge_Click(object sender, EventArgs e)
        {
            btnSterge_Click(sender, e);
        }

        private void ctxMarcheazaFinalizata_Click(object sender, EventArgs e)
        {
            try
            {
                Activitate selectata = GetActivitateSelectata();
                if(selectata!=null)
                {
                    agenda.MarcheazaFinalizata(selectata.Id);
                    RefreshListView();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxCrestePrioritate_Click(object sender, EventArgs e)
        {
            Activitate selectata = GetActivitateSelectata();
            if(selectata!=null)
            {
                selectata.Prioritate = selectata.Prioritate + 1;
                RefreshListView();
            }
        }

        private void ctxScadePrioritate_Click(object sender, EventArgs e)
        {
            Activitate selectata = GetActivitateSelectata();
            if(selectata!=null)
            {
                selectata.Prioritate = selectata.Prioritate - 1;
                RefreshListView();
            }
        }

        private void lvActivitati_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Listview events
        private void lvActivitati_DoubleClick(object sender, EventArgs e)
        {
            btnEditeaza_Click(sender, e);
        }

        private Color GetCuloareDomeniu(string culoare)
        {
            switch (culoare?.ToLower())
            {
                case "albastru": return Color.DarkBlue;
                case "rosu":     return Color.DarkRed;
                case "verde":    return Color.DarkGreen;
                case "galben":   return Color.DarkGoldenrod;
                case "portocaliu": return Color.DarkOrange;
                case "mov":      return Color.Purple;
                case "roz":      return Color.DeepPink;
                case "gri":      return Color.Gray;
                default:         return Color.Black;
            }
        }

        //FILTRE
        private void cbFiltruDomeniu_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void cbFiltruStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshListView();
        }

    }
}
