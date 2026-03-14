using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProiectPAW
{
    public enum StatusActivitate
    {
        Noua,
        InProgres,
        Finalizata,
        Anulata
    }
    public class Activitate:ElementAgenda,ICloneable,IComparable
    {
        #region Atribute
        private Domeniu domeniu;
        private DateTime dataStart;
        private DateTime dataEnd;
        private int prioritate; //1-5, 1 fiind cea mai mica prioritate
        private StatusActivitate status;
        private string locatie;
        #endregion

        #region Proprietati
        public Domeniu Domeniu
        {
            get { return this.domeniu; }
            set { this.domeniu = value ?? throw new Exception("Domeniul nu poate fi gol!"); }
        }
        public DateTime DataStart
        {
            get { return this.dataStart; }
            set { this.dataStart = value; }
        }
        public DateTime DataEnd
        {
            get { return this.dataEnd; }
            set
            {
                if (value < dataStart)
                    throw new Exception("Data de sfarsit nu poate fi inaintea datei de start.\" ");
                this.dataEnd = value;
            }
        }
        public int Prioritate
        {
            get { return this.prioritate; }
            set
            {
                if (value < 1) this.prioritate = 1;
                else if (value > 5) this.prioritate = 5;
                else this.prioritate = value;
            }
        }
        public StatusActivitate Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Locatie
        {
            get { return locatie; }
            set { locatie = value ?? ""; }
        }
        #endregion

        #region Constructori
        public Activitate():base()
        {
            this.domeniu = new Domeniu("General");
            this.dataStart = DateTime.Now;
            this.dataEnd = DateTime.Now.AddDays(7);
            this.prioritate = 3;
            this.status = StatusActivitate.Noua;
            this.locatie = "Necunoscuta";
        }

        public Activitate(string titlu,Domeniu domeniu, DateTime dataStart, DateTime dataEnd, int prioritate=3,string descriere="",string locatie="")
            :base(titlu,descriere)
        {
            this.domeniu = domeniu ?? throw new Exception("Domeniul neprecizat!");
            this.dataStart = dataStart;
            if (dataEnd < this.dataStart)
                throw new Exception("Data de sfarsit trebuie sa fie inaintea datei de inceput!");
            this.dataEnd = dataEnd;
            this.prioritate = prioritate;
            this.status = StatusActivitate.Noua;
            this.locatie = locatie;
        }
        //const de copiere
        public Activitate(Activitate a):base(a)
        {
            this.domeniu = (Domeniu)a.domeniu.Clone();
            this.dataStart = a.DataStart;
            this.dataEnd = a.DataEnd;
            this.prioritate=a.Prioritate;
            this.status=a.Status;
            this.locatie = a.Locatie;
        }
        //metoda abstracta implementata
        public override string sumar()
        {
            return $"{Titlu} [{Domeniu.Titlu}] | {DataStart:dd.MM} - {DataEnd:dd.MM} | " +
                   $"Prioritate: {Prioritate} | Status: {Status}";
        }

        public object Clone()
        {
            //apelam constructorul de copiere
            return new Activitate(this);
        }

        //comparam dupa dataStart,apoi dupa Prioritate(descrescator)
        public int CompareTo(object obj)
        {
            Activitate a= (Activitate)obj;
            int cmpData = this.dataStart.CompareTo(a.DataStart);
            if (cmpData != 0) return cmpData;
            else 
            {  //daca au aceeasi data , prioritatea mai mare vine prima
                return a.Prioritate.CompareTo(this.prioritate);
            }
        }


        #endregion

        #region Supraincarcare operatori
        //supraincarcare operatori
        public static bool operator < (Activitate a, Activitate b)
        {
            if (a is null || b is null) return false;
            return a.prioritate < b.prioritate;
        }
        public static bool operator>(Activitate a, Activitate b)
        {
            if (a is null || b is null) return false;
            return a.prioritate > b.prioritate;
        }
        
        //Incrementare prioritate
        public static Activitate operator++(Activitate a)
        {
            if (a is null) return null;
            a.Prioritate = a.Prioritate + 1;
            return a;
        }
        public static Activitate operator--(Activitate a)
        {
            if (a is null) return null;
            a.Prioritate = a.Prioritate - 1;
            return a;
        }
        
        //cast explicit la string->returneaza un rezumat scurt
        public static explicit operator string(Activitate a)
        {
            if (a is null) return "null";
            return a.sumar();
        }
        #endregion

        #region Metode
        public bool esteInTermen()
        {
            return DateTime.Now <= this.DataEnd;
        }
        public TimeSpan DurataEstimata()
        {
            return this.DataEnd - this.DataStart;
        }
        public void MarcheazaFinalizata()
        {
            this.status = StatusActivitate.Finalizata;
        }
        //marcheaza activitatea ca fiind in progres=>incepe activitate
        public void IncepeActivitatea()
        {
            if (this.Status == StatusActivitate.Noua)
                this.Status = StatusActivitate.InProgres;
        }
        public bool EsteUrgenta()
        {
            if(this.Status!=StatusActivitate.Finalizata && this.Status!=StatusActivitate.Anulata)
            {
                if ((this.DataEnd - DateTime.Now).TotalDays <= 2)
                    return true;
                return false;
            }
            return false;
        }

        public override string ExportText()
        {
            return base.ExportText() +
                   $"\nDomeniu: {Domeniu.Titlu}" +
                   $"\nData start: {DataStart:dd.MM.yyyy}" +
                   $"\nData sfarsit: {DataEnd:dd.MM.yyyy}" +
                   $"\nPrioritate: {Prioritate}" +
                   $"\nStatus: {Status}" +
                   $"\nLocatie: {Locatie}";
        }

        public override string ExportXML()
        {
            return $"<Activitate>\n" +
                  $"  <Id>{Id}</Id>\n" +
                  $"  <Titlu>{Titlu}</Titlu>\n" +
                  $"  <Descriere>{Descriere}</Descriere>\n" +
                  $"  <Domeniu>{Domeniu.Titlu}</Domeniu>\n" +
                  $"  <DataStart>{DataStart:yyyy-MM-dd}</DataStart>\n" +
                  $"  <DataEnd>{DataEnd:yyyy-MM-dd}</DataEnd>\n" +
                  $"  <Prioritate>{Prioritate}</Prioritate>\n" +
                  $"  <Status>{Status}</Status>\n" +
                  $"  <Locatie>{Locatie}</Locatie>\n" +
                  $"</Activitate>";
        }

        public override string ToString()
        {
            string urgenta = EsteUrgenta() ? "[URGENT!]" : "";
            return $"[Activitate] {Titlu} | {Domeniu.Titlu} | P:{Prioritate} | {Status}{urgenta}";
        }
        #endregion
    }
}
