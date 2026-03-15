using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Proiect : ElementAgenda, ICloneable, IComparable
    {
        #region Atribute
        private Activitate[] activitati;
        private int count; //nr activitati
        private Domeniu domeniu;
        private DateTime deadLine;
        private float procentFinalizare;
        #endregion
        private const int CAPACITATE_INITIALA = 10; //capacitatea initiala a array-ului

        #region Constructori
        //Constructor default
        public Proiect() : base()
        {
            this.activitati = new Activitate[Proiect.CAPACITATE_INITIALA];
            this.count = 0;
            this.domeniu = new Domeniu("General");
            this.deadLine = DateTime.Now.AddMonths(1);
        }
        // Constructor cu parametri
        public Proiect(string titlu, Domeniu domeniu, DateTime deadline, string descriere = "")
            : base(titlu, descriere)
        {
            activitati = new Activitate[CAPACITATE_INITIALA];
            count = 0;
            this.domeniu = domeniu ?? throw new ArgumentNullException(nameof(domeniu));
            this.deadLine = deadline;
        }
        #endregion

        #region Proprietati
        public int Count { get { return this.count; } }
        public Domeniu Domeniu
        {
            get { return this.domeniu; }
            set
            {
                this.domeniu = value ?? throw new Exception("Domeniul nu poate fi NULL");
            }
        }
        public DateTime DeadLine
        {
            get { return this.deadLine; }
            set { this.deadLine = value; }
        }
        public float ProcentFinalizare
        {
            get { return CalculeazaProcentFinalizare(); }
        }
        #endregion


        #region Indexer
        //acces la activitati prin index numeric
        public Activitate this[int index]
        {
            get
            {
                if (index < 0 || index >= this.count) throw new Exception("Index out of range");
                return this.activitati[index];
            }
            set
            {
                if (index < 0 || index >= this.count) throw new Exception("Index out of range");
                this.activitati[index] = value ?? throw new Exception("Activitatea nu poate fi NULL");
            }
        }

        public Activitate this[string Titlu]
        {
            get
            {
                for (int i = 0; i < this.count; i++)
                {
                    if (String.Equals(this.activitati[i].Titlu, Titlu)) return this.activitati[i];
                }
                return null;
            }
            set
            {
                for (int i = 0; i < this.count; i++)
                {
                    if (String.Equals(this.activitati[i].Titlu, Titlu)) this.activitati[i].Titlu = value.ToString();
                }
            }

        }
        #endregion

        #region Metode
        public object Clone()
        {
            Proiect clona = (Proiect)this.MemberwiseClone();
            clona.activitati = new Activitate[this.activitati.Length];
            for (int i = 0; i < this.count; i++)
            {
                clona.activitati[i] = (Activitate)this.activitati[i].Clone();
            }
            return clona;
        }

        //compara dupa deadline, daca nu dupa procentFinalizare
        public int CompareTo(object obj)
        {
            Proiect activitateObj = (Proiect)obj;
            int cmpDeadLine = this.deadLine.CompareTo(activitateObj.deadLine);
            if (cmpDeadLine != 0) return cmpDeadLine;
            else
                return this.CalculeazaProcentFinalizare().CompareTo(activitateObj.CalculeazaProcentFinalizare());
        }
        private float CalculeazaProcentFinalizare()
        {
            if (this.count == 0) return 0f;
            int finalizate = 0;
            for (int i = 0; i < this.count; i++)
            {
                if (this.activitati[i].Status == StatusActivitate.Finalizata) finalizate++;
            }
            return (float)finalizate / this.count * 100;
        }
        //metoda abstracta implementat
        public override string sumar()
        {
            return $"Proiect: {this.Titlu} [{this.Domeniu.Titlu}] | {this.count} activitati | " +
                   $"Finalizare: {this.ProcentFinalizare:F1}% | Deadline: {this.DeadLine:dd.MM.yyyy}";
        }
        #region Metode pe array ul de activitati
        public void AdaugaActivitate(Activitate activitate)
        {
            Activitate[] copie = new Activitate[this.activitati.Length + 1];
            for (int i = 0; i < this.count; i++)
            {
                copie[i] = this.activitati[i];
            }
            copie[this.count] = activitate;
            this.activitati = copie;
            this.count++;
        }
        //elimina activitate dupa id
        public void EliminaActivitate(int id)
        {
            Activitate[] copie = new Activitate[this.activitati.Length];
            int indexCopie = 0;
            for (int i = 0; i < this.count; i++)
            {
                if (this.activitati[i].Id != id)
                {
                    copie[indexCopie] = this.activitati[i];
                    indexCopie++;
                }
            }
            this.activitati = copie;
            this.count = indexCopie;
        }

        public void SorteazaDupaPrioritate()
        {
            for(int i=0; i<this.count;i++)
            {
                for (int j = 0; j < this.count - 1 - i; j++)
                {
                    if (this.activitati[j].Prioritate < this.activitati[j + 1].Prioritate)
                    {
                        Activitate temp = this.activitati[j];
                        this.activitati[j] = this.activitati[j + 1];
                        this.activitati[j + 1] = temp;
                    }
                }
            }
        }
        public void SorteazaDupaDataStart()
        {
            for (int i = 0; i < this.count; i++)
            {
                for (int j = 0; j < this.count - 1 - i; j++)
                {
                    if (this.activitati[j].DataStart > this.activitati[j + 1].DataStart)
                    {
                        Activitate temp = this.activitati[j];
                        this.activitati[j] = this.activitati[j + 1];
                        this.activitati[j + 1] = temp;
                    }
                }
            }
        }
        //returneaza toate activitatile care au un anumit status
        public Activitate[] FiltreazaDupaStatus(StatusActivitate status)
        {
            //numaram cate activitati au statusul respectiv
            int countStatus = 0;
            for (int i = 0; i < this.count; i++)
            {
                if (this.activitati[i].Status == status) countStatus++;
            }
            //cream un array de activitati cu dimensiunea countStatus
            Activitate[] filtrate = new Activitate[countStatus];
            int indexFiltrate = 0;
            for (int i = 0; i < this.count; i++)
            {
                if (this.activitati[i].Status == status)
                {
                    filtrate[indexFiltrate] = this.activitati[i];
                    indexFiltrate++;
                }
            }
            return filtrate;
        }
        //verifica daca proiectul este in intarziere(deadline depasit si nu este finalizat)
        public bool EsteInIntarziere()
        {
            return DateTime.Now > this.deadLine && this.ProcentFinalizare < 100;
        }
        //returneaza activitatea cu prioritatea cea mai mare
        public Activitate ActivitatePrioritara()
        {
            if (this.count == 0) return null;
            Activitate prioritara = this.activitati[0];
            for (int i = 1; i < this.count; i++)
            {
                if (this.activitati[i].Prioritate > prioritara.Prioritate)
                {
                    prioritara = this.activitati[i];
                }
            }
            return prioritara;
        }

        #endregion
        
        #endregion

        #region Operatori
        public static Proiect operator +(Proiect p, Activitate act)
        {
            p.AdaugaActivitate(act);
            return p;
        }
        public static Proiect operator -(Proiect p, int idActivitate)
        {
            p.EliminaActivitate(idActivitate);
            return p;
        }
        public static Proiect operator -(Proiect p, Activitate act)
        {
            if (act != null) p.EliminaActivitate(act.Id);
            return p;
        }
        //compara dupa nr de activitati
        public static bool operator >(Proiect p1, Proiect p2)
        {
            return p1.count > p2.count;
        }
        public static bool operator <(Proiect p1, Proiect p2)
        {
            return p1.count < p2.count;
        }
        #endregion

        #region Override 
        public override string ExportText()
        {
            string text = base.ExportText() +
                          $"\nDomeniu: {this.Domeniu.Titlu}" +
                          $"\nDeadline: {this.deadLine:dd.MM.yyyy}" +
                          $"\nFinalizare: {this.ProcentFinalizare:F1}%" +
                          $"\nActivitati ({this.count}):";

            for (int i = 0; i < this.count; i++)
            {
                text += $"\n  {i + 1}. {this.activitati[i].sumar()}";
            }
            return text;
        }
        public override string ExportXML()
        {
            string xml = $"<Proiect>\n" +
                         $"  <Id>{Id}</Id>\n" +
                         $"  <Titlu>{Titlu}</Titlu>\n" +
                         $"  <Descriere>{Descriere}</Descriere>\n" +
                         $"  <Domeniu>{Domeniu.Titlu}</Domeniu>\n" +
                         $"  <Deadline>{deadLine:yyyy-MM-dd}</Deadline>\n" +
                         $"  <Activitati>\n";

            for (int i = 0; i < count; i++)
            {
                xml += "    " + activitati[i].ExportXML().Replace("\n", "\n    ") + "\n";
            }

            xml += $"  </Activitati>\n</Proiect>";
            return xml;

        }

        public override string ToString()
        {
            string intarziere = EsteInIntarziere() ? " [INTARZIAT!]" : "";
            return $"[Proiect] {this.Titlu} | {this.Domeniu.Titlu} | {this.count} activitati | " +
                   $"{this.ProcentFinalizare:F0}% finalizat{intarziere}";
        }
        #endregion

        

    }
}
