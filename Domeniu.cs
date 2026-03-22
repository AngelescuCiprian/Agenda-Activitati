using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Domeniu:ElementAgenda,ICloneable,IComparable 
    {
        private string culoare;
        #region Constructori
        public string Culoare { get => culoare; set => culoare = value ?? "Gri"; }

        public Domeniu():base()
        {
            this.culoare = "Gri";
        }

        public Domeniu(string titlu) : base(titlu, "")
        {
            this.culoare = "Gri";
        }

        public Domeniu(string titlu,string descriere, string culoare):base(titlu,descriere)
        {
            this.culoare = culoare;
        }
        //constructor copiere
        public Domeniu(Domeniu d):base(d)
        {
            this.culoare = d.culoare;
        }
        #endregion
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        //comparam alfabetic dupa titlu, daca titlurile sunt egale, comparam dupa data crearii
        public int CompareTo(object obj)
        {
            Domeniu d=(Domeniu)obj;
            if(this.Titlu.CompareTo(d.Titlu)!=0)
            {
                return String.Compare(this.Titlu, d.Titlu);
            }
            else
            {
                return this.DataCreare.CompareTo(d.DataCreare);
            }
        }

        public override string sumar()
        {
            return $"Domeniu: {this.Titlu} (Culoare: {this.Culoare})";
        }

        #region Supraincarcare operatori
        //Supraincarcare operatori
        // Comparatie: un domeniu e "mai mic" daca vine inaintea celuilalt alfabetic
        public static bool operator<(Domeniu d1, Domeniu d2)
        {
            if (d1 is null || d2 is null) return false;
            return d1.CompareTo(d2) < 0;
        }
        public static bool operator >(Domeniu d1, Domeniu d2)
        {
            if (d1 is null || d2 is null) return false;
            return d1.CompareTo(d2) > 0;
        }
        //operator == pe baza titlului
        public static bool operator==(Domeniu d1, Domeniu d2)
        {
            if (d1 is null && d2 is null) return true;
            if (d1 is null || d2 is null) return false;
            return String.Equals(d1.Titlu, d2.Titlu);
        }
        public static bool operator !=(Domeniu d1, Domeniu d2)
        {
            return !(d1 == d2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Domeniu)) return false;
            return this == (Domeniu)obj;
        }
        public override int GetHashCode()
        {
            return Titlu?.GetHashCode() ?? 0;
        }
        #endregion

        #region Metode
        //verificare daca un domeniu contine un cuvant cheie in titlu sau descriere
        public bool ContineText(string text)
        {
            if(string.IsNullOrEmpty(text)) return false;
            return this.Titlu.Contains(text) || this.Descriere.Contains(text);
        }
        
        public Domeniu Redenumeste(string titluNou)
        {
            if(string.IsNullOrEmpty(titluNou))
                throw new Exception("Titlul nou nu poate fi gol.");
            Domeniu copie = (Domeniu)this.Clone();
            copie.Titlu = titluNou;
            return copie;
        }
        #endregion

        #region Override IExportabil
        public override string ExportText()
        {
            return base.ExportText() + $"\nCuloare: {Culoare}";
        }
        public override string ExportXML()
        {
            return $"<Domeniu>\n" +
                   $"  <Id>{Id}</Id>\n" +
                   $"  <Titlu>{Titlu}</Titlu>\n" +
                   $"  <Descriere>{Descriere}</Descriere>\n" +
                   $"  <Culoare>{Culoare}</Culoare>\n" +
                   $"  <DataCreare>{DataCreare:yyyy-MM-ddTHH:mm:ss}</DataCreare>\n" +
                   $"</Domeniu>";
        }

        public override string ToString()
        {
            return $"[Domeniu] {Titlu} | Culoare: {Culoare}";
        }
        #endregion
    }
}
