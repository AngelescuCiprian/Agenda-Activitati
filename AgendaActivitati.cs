using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    #region DELEGATE
    //Pas1.Definim o clasa de argumente pt solutii personalizate(drrivata din EventArgs)
    public class AgendaEventArgs:EventArgs
    {
        public string Actiune {  get; set; } //ex: "ADAUGARE", "STERGERE"
        public string NumeElement { get; set; } // ex: "Proiect C#"

        public AgendaEventArgs(string actiune,string numeElement)
        {
            this.Actiune=actiune;
            this.NumeElement=numeElement;
        }
    }
    //Pas 2. Delegatul
    public delegate void AgendaEventHandler(object sender, AgendaEventArgs e);
    #endregion
    public class AgendaActivitati
    {
        #region Eventul
        public event AgendaEventHandler NotificareModificare;
        //Pas4. Functia care activeaza delegatul
        private void DeclanseazaNotificare(string actiune, string numeElement)
        {
            if(NotificareModificare != null)
            {
                NotificareModificare(this,new AgendaEventArgs(actiune,numeElement));
            }
        }
        #endregion
        #region Colectii
        private List<Domeniu> domenii;
        private List<Activitate> activitati;
        private List<Proiect> proiecte;
        #endregion

        #region Proprietati
        public List<Domeniu> Domenii
        {
            get { return this.domenii; }
        }
        public List<Activitate> Activitati
        {
            get { return this.activitati; }
        }
        public List<Proiect> Proiecte
        {
            get { return this.proiecte; }
        }
        public int TotalActivitati
        {
            get { return this.activitati.Count; }
        }
        public int TotalProiecte
        {
            get { return this.proiecte.Count; }
        }
        #endregion
        #region Constructor
        public AgendaActivitati()
        {
            this.domenii = new List<Domeniu>();
            this.activitati = new List<Activitate>();
            this.proiecte = new List<Proiect>();
        }
        #endregion

        #region Gestionare Domenii
        public void AdaugaDomeniu(Domeniu d)
        {
            if (d == null) throw new Exception("Domeniu nu poate fi null");
            //verificam sa nu existe deja un domeniu cu acelasi titlu
            foreach(Domeniu existent in domenii)
            {
                if (existent == d)//operatorul== supraincarcat
                    throw new Exception($"Domeniul '{d.Titlu}' exista deja.");
            }
            this.domenii.Add(d);
            DeclanseazaNotificare("ADAUGARE", d.Titlu);
        }
        public void StergeDomeniu(int id)
        {
            for(int i=0;i<this.domenii.Count;i++)
            {
                if (this.domenii[i].Id==id)
                {
                    string titluSters = this.domenii[i].Titlu;
                    this.domenii.RemoveAt(i);
                    DeclanseazaNotificare("STERGERE", titluSters);
                    return;
                }
            }
            throw new Exception($"Domeniul cu id={id} nu a fost gasit.");
        }
        public Domeniu GasesteDomeniu(string titlu)
        {
            foreach(Domeniu d in this.domenii)
            {
                if (string.Equals(d.Titlu, titlu))
                    return d;
            }
            return null;
        }
        #endregion

        #region Gestionare Activitati
        public void AdaugaActivitate(Activitate a)
        {
            if(a==null) throw new Exception("Activitate nu poate fi null");
            this.activitati.Add(a);
            DeclanseazaNotificare("ADAUGARE", a.Titlu);
        }
        public void StergeActivitate(int id)
        {
            for(int i=0;i<this.activitati.Count;i++)
            {
                if (this.activitati[i].Id==id)
                {
                    string titluSters = this.activitati[i].Titlu;
                    this.activitati.RemoveAt(i);
                    DeclanseazaNotificare("STERGERE", titluSters);
                    return;
                }
            }
            throw new Exception("Activitatea nu a fost gasita");
        }
        public Activitate GasesteActivitate(int id)
        {
            foreach(Activitate activitate in this.activitati)
            {
                if(activitate.Id==id)
                    { return activitate; }
            }
            return null;
        }
        public void MarcheazaFinalizata(int id)
        {
            Activitate a = GasesteActivitate(id);
            if(a!=null)
            {
                a.MarcheazaFinalizata();
                DeclanseazaNotificare("FINALIZARE", a.Titlu);
            }
        }
        #endregion

        #region Gestionare proiecte
        public void AdaugaProiect(Proiect p)
        {
            if (p == null) throw new Exception("Proiectul nu poate fi null");
            this.proiecte.Add(p);
            DeclanseazaNotificare("ADAUGARE", p.Titlu);
        }
        public void StergeProiect(int id)
        {
            for(int i=0;i<this.proiecte.Count;i++)
            {
                if (this.proiecte[i].Id==id)
                {
                    string titluSters = this.proiecte[i].Titlu;
                    this.proiecte.RemoveAt(i);
                    DeclanseazaNotificare("STERGERE", titluSters);
                    return;
                }
            }
            throw new Exception($"Proiectul cu id {id} nu exista");
        }

        #endregion

        #region SORTARI
        public List<Activitate> SorteazaActivitateDupaData()
        {
            List<Activitate> sortate = new List<Activitate>(activitati);
            sortate.Sort();//foloseste IComparable implementat in Activitate
            return sortate;
        }
        //sorteaza activitatile dupa prioritate descrescator
        public List<Activitate> SorteazaActivitateDupaPrioritate()
        {
            List<Activitate> sortate = new List<Activitate>(activitati);
            sortate.Sort((a1,a2) => a2.Prioritate.CompareTo(a1.Prioritate));//folosim o expresie lambda pentru a compara prioritatile in ordine descrescatoare
            return sortate;
        }

        //sorteaza domeniile alfabetic dupa titlu
        public List<Domeniu> SorteazaDomeniiAlfabetic()
        {
            List<Domeniu> sortate = new List<Domeniu>(domenii);
            sortate.Sort();// foloseste IComparable implementat in Domenii
            return sortate;
        }
        //comapra proiectele dupa deadline
        public List<Proiect> SorteazaProiectDupaDeadline()
        {
            List<Proiect> sortate = new List<Proiect>(proiecte);
            sortate.Sort(); //foloseste IComparable din Proiecte
            return sortate;
        }
        #endregion

        #region Filtrari
        //returneaza activitatiile dintr un anumit domeniu
        public List<Activitate> FiltreazaDupaDomeniu(Domeniu domeniu)
        {
            List<Activitate> rezultat = new List<Activitate>();
            foreach(Activitate a in activitati)
            {
                if(a.Domeniu==domeniu)
                    rezultat.Add(a);
            }
            return rezultat;
        }
        //returneaza activitatiile cu un anumit status
        public List<Activitate> FiltreazaDupaStatus(StatusActivitate status)
        {
            List<Activitate> rezultat = new List<Activitate>();
            foreach(Activitate a in activitati)
            {
                if(a.Status==status)
                    rezultat.Add(a);
            }
            return rezultat;
        }
        //returneaza activitatiile urgente
        public List<Activitate> FiltreazaDupaInterval(DateTime start, DateTime End)
        {
            List<Activitate> rezultat = new List<Activitate>();
            foreach(Activitate a in activitati)
            {
                if (a.DataStart >= start && a.DataStart <= End)
                    rezultat.Add(a);
            }
            return rezultat;
        }
        #endregion

        #region Statistici
        //nr de activitati per domeniu
        public Dictionary<string,int> StatisticiPerDomeniu()
        {
            Dictionary<string, int> stats = new Dictionary<string, int>();
            foreach(Activitate a in activitati)
            {
                string numeDomeniu = a.Domeniu.Titlu;
                if (stats.ContainsKey(numeDomeniu))
                    stats[numeDomeniu]++;
                else
                    stats[numeDomeniu] = 1;
            }
            return stats;
        }
        //returneazza nr de activitati per status
        public Dictionary<StatusActivitate, int> StatisticiPerStatus()
        {
            Dictionary<StatusActivitate, int> stats = new Dictionary<StatusActivitate, int>();
            foreach (StatusActivitate s in Enum.GetValues(typeof(StatusActivitate)))
                stats[s] = 0;

            foreach (Activitate a in activitati)
                stats[a.Status]++;

            return stats;
        }

        #endregion

        #region Salvare/Restaurare fisier text
        public void SalveazaInFisier(string caleFisier)
        {
            using (StreamWriter sw = new StreamWriter(caleFisier))
            {
                //salvam domeniile
                sw.WriteLine($"#DOMENII:{domenii.Count}");
                foreach (Domeniu d in this.domenii)
                {
                    sw.WriteLine($"{d.Id}|{d.Titlu}|{d.Culoare}|{d.Descriere}");
                }
                //salvam activitatiile
                sw.WriteLine($"#ACTIVITATI:{activitati.Count}");
                foreach (Activitate a in this.activitati)
                {
                    sw.WriteLine($"{a.Id}|{a.Titlu}|{a.Domeniu.Titlu}|{a.DataStart:yyyy-MM-dd}|" +
                                    $"{a.DataEnd:yyyy-MM-dd}|{a.Prioritate}|{a.Status}|{a.Locatie}|{a.Descriere}");
                }
                //salvam proiectele
                sw.WriteLine($"#PROIECTE:{proiecte.Count}");
                foreach (Proiect p in proiecte)
                {
                    // Salvam header-ul proiectului
                    sw.WriteLine($"{p.Id}|{p.Titlu}|{p.Domeniu.Titlu}|{p.DeadLine:yyyy-MM-dd}|{p.Count}|{p.Descriere}");

                    // Salvam ID-urile activitatilor din proiect
                    StringBuilder ids = new StringBuilder();
                    for (int i = 0; i < p.Count; i++)
                    {
                        if (i > 0) ids.Append(",");
                        ids.Append(p[i].Id);
                    }
                    sw.WriteLine(ids.ToString());
                }
            }
            DeclanseazaNotificare("SALVARE", caleFisier);
        }

        public void RestaureazaDinFisier(string caleFisier)
        {
            if (!File.Exists(caleFisier)) throw new Exception("Fisierul nu exista");

            //curatam colectiile existente
            this.domenii.Clear();
            this.activitati.Clear();
            this.proiecte.Clear();

            // Mapa intre ID-ul vechi din fisier si obiectul Activitate restaurat
            Dictionary<int, Activitate> mapIdActivitate = new Dictionary<int, Activitate>();

            using (StreamReader sr = new StreamReader(caleFisier))
            {
                string linie;
                //restauram domeniile
                linie = sr.ReadLine(); // #DOMENII:N
                if (linie != null && linie.StartsWith("#DOMENII:"))
                {
                    int nrDomenii = int.Parse(linie.Substring(9));
                    for (int i = 0; i < nrDomenii; i++)
                    {
                        linie = sr.ReadLine();
                        if (linie == null) break;

                        string[] parti = linie.Split('|');
                        // parti: Id | Titlu | Culoare | Descriere
                        Domeniu d = new Domeniu(parti[1], parti[3], parti[2]); // titlu, descriere, culoare
                        domenii.Add(d);
                    }
                }
                //restauram activitatile
                linie = sr.ReadLine(); // #ACTIVITATI:N
                if (linie != null && linie.StartsWith("#ACTIVITATI:"))
                {
                    int nrActivitati = int.Parse(linie.Substring(12));
                    for (int i = 0; i < nrActivitati; i++)
                    {
                        linie = sr.ReadLine();
                        if (linie == null) break;

                        string[] parti = linie.Split('|');
                        // parti: Id | Titlu | NumeDomeniu | DataStart | DataEnd | Prioritate | Status | Locatie | Descriere

                        // Retinem ID-ul vechi din fisier
                        int idVechi = int.Parse(parti[0]);

                        // Gasim domeniul dupa titlu
                        Domeniu dom = GasesteDomeniu(parti[2]);
                        if (dom == null)
                        {
                            dom = new Domeniu(parti[2]);
                            domenii.Add(dom);
                        }

                        Activitate a = new Activitate(
                            parti[1],                                    // titlu
                            dom,                                         // domeniu
                            DateTime.Parse(parti[3]),                    // dataStart
                            DateTime.Parse(parti[4]),                    // dataEnd
                            int.Parse(parti[5]),                         // prioritate
                            parti.Length > 8 ? parti[8] : "",            // descriere
                            parti.Length > 7 ? parti[7] : ""             // locatie
                        );

                        // Setam statusul
                        if (Enum.TryParse(parti[6], out StatusActivitate status))
                            a.Status = status;

                        activitati.Add(a);
                        // Mapam ID-ul vechi la noul obiect pentru a restaura proiectele corect
                        mapIdActivitate[idVechi] = a;
                    }
                }
                //restauram proiectele
                linie = sr.ReadLine(); // #PROIECTE:N
                if (linie != null && linie.StartsWith("#PROIECTE:"))
                {
                    int nrProiecte = int.Parse(linie.Substring(10));
                    for (int i = 0; i < nrProiecte; i++)
                    {
                        linie = sr.ReadLine();
                        if (linie == null) break;

                        string[] parti = linie.Split('|');
                        // parti: Id | Titlu | NumeDomeniu | Deadline | NrActivitati | Descriere

                        Domeniu dom = GasesteDomeniu(parti[2]);
                        if (dom == null)
                        {
                            dom = new Domeniu(parti[2]);
                            domenii.Add(dom);
                        }

                        Proiect p = new Proiect(
                            parti[1],                       // titlu
                            dom,                            // domeniu
                            DateTime.Parse(parti[3]),       // deadline
                            parti.Length > 5 ? parti[5] : "" // descriere
                        );

                        // Citim linia cu ID-urile activitatilor
                        string linieIds = sr.ReadLine();
                        if (!string.IsNullOrWhiteSpace(linieIds))
                        {
                            string[] ids = linieIds.Split(',');
                            foreach (string idStr in ids)
                            {
                                if (int.TryParse(idStr.Trim(), out int actId))
                                {
                                    // Folosim mapa pentru a gasi activitatea dupa ID-ul vechi din fisier
                                    if (mapIdActivitate.TryGetValue(actId, out Activitate act))
                                        p.AdaugaActivitate(act);
                                }
                            }
                        }

                        proiecte.Add(p);
                    }
                }
            }
            DeclanseazaNotificare("RESTAURARE", caleFisier);
        }
        #endregion

        #region ExportXML
        //exporta toata agenda in format XML
        public string ExportXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sb.AppendLine("<Agenda>");

            sb.AppendLine("  <Domenii>");
            foreach (Domeniu d in domenii)
                sb.AppendLine("    " + d.ExportXML().Replace("\n", "\n    "));
            sb.AppendLine("  </Domenii>");

            sb.AppendLine("  <Activitati>");
            foreach (Activitate a in activitati)
                sb.AppendLine("    " + a.ExportXML().Replace("\n", "\n    "));
            sb.AppendLine("  </Activitati>");

            sb.AppendLine("  <Proiecte>");
            foreach (Proiect p in proiecte)
                sb.AppendLine("    " + p.ExportXML().Replace("\n", "\n    "));
            sb.AppendLine("  </Proiecte>");

            sb.AppendLine("</Agenda>");
            return sb.ToString();
        }
        //salveaza agenda in format XML intr-un fisier
        public void SalveazaInFisierXML(string caleFisier)
        {
            string xml = ExportXML();
            File.WriteAllText(caleFisier, xml);
            DeclanseazaNotificare("SALVARE_XML", caleFisier);
        }
        #endregion
        #region ToString
        public override string ToString()
        {
            return $"Agenda: {domenii.Count} domenii, {activitati.Count} activitati, {proiecte.Count} proiecte";
        }
        #endregion
    }
}
