using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public abstract class ElementAgenda:IExportabil
    {
        #region Atribute
        private static int contorID = 0; // Contor static pentru generarea ID-urilor unice

        private int id;
        private String titlu;
        private string descriere;
        private DateTime dataCreare;
        #endregion
        #region Constructori
        public int Id { get => id; private set => id = value; }
        public string Titlu
        {
            get {  return titlu; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new Exception("Titlul nu poate fi gol.");
                titlu = value;
            }
        }
        public string Descriere { get => descriere; set => descriere = value ?? " "; }
        public DateTime DataCreare { get => dataCreare; set => dataCreare = value; }

        //Constructor implicit
        public ElementAgenda()
        {
            this.id = ++ElementAgenda.contorID;
            this.titlu = "NECUNOSCUT";
            this.descriere = "NESPECIFICAT";
            this.dataCreare = DateTime.Now;
        }
        //constructor cu parametri
        public ElementAgenda(string titlu,string descriere)
        {
            this.id = ++ElementAgenda.contorID;
            this.titlu = titlu;
            this.descriere = descriere;
            this.dataCreare = DateTime.Now;
        }
        //constructor de copiere
        public ElementAgenda(ElementAgenda ea)
        {
            this.id=++ElementAgenda.contorID;
            this.titlu = ea.titlu;
            this.descriere = ea.descriere;
            this.dataCreare = DateTime.Now;
        }
        #endregion
        public abstract String sumar(); //metoda abstracta care va fi implementata in clasele derivate pentru a returna un sumar al elementului de agenda

        public override string ToString()
        {
            return $"[{Id}] {Titlu} (creat: {DataCreare:dd.MM.yyyy})";
        }

        public virtual string ExportText()
        {
            return $"ID: {Id}\nTitlu: {Titlu}\nDescriere: {Descriere}\nData creare: {DataCreare:dd.MM.yyyy HH:mm}";
        }

        public virtual string ExportXML()
        {
            return $"<Element>\n" +
                   $"  <Id>{Id}</Id>\n" +
                   $"  <Titlu>{Titlu}</Titlu>\n" +
                   $"  <Descriere>{Descriere}</Descriere>\n" +
                   $"  <DataCreare>{DataCreare:yyyy-MM-ddTHH:mm:ss}</DataCreare>\n" +
                   $"</Element>";
        }

    }
}
