using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== AGENDA DE ACTIVITATI - Test Clase ===\n");
            #region Testare Domenii
            Console.WriteLine("--- Creare domenii ---");
            Domeniu facultate = new Domeniu("Facultate", "Activitati legate de cursuri si seminarii", "Albastru");
            Domeniu munca = new Domeniu("Munca", "Activitati profesionale", "Rosu");
            Domeniu personal = new Domeniu("Personal", "Activitati personale", "Verde");
            Console.WriteLine(facultate.ToString());
            Console.WriteLine(munca);
            Console.WriteLine(personal);

            // Test IComparable (compara alfabetic)
            Console.WriteLine($"\nFacultate < Munca? {facultate < munca}");   // true (F < M)
            Console.WriteLine($"Personal > Munca? {personal > munca}");       // true (P > M)

            // Test ICloneable
            Domeniu copiedomeniu = (Domeniu)facultate.Clone();
            Console.WriteLine($"\nClona domeniu: {copiedomeniu}");
            Console.WriteLine($"Originala == Clona (dupa titlu)? {facultate == copiedomeniu}"); // true
            #endregion

            #region Testare Activitati
            Console.WriteLine("\n--- Creare activitati ---");
            Activitate a1 = new Activitate(
               "Proiect C#", facultate,
               DateTime.Now, DateTime.Now.AddDays(21),
               prioritate: 4,
               descriere: "Realizare proiect semestrial",
               locatie: "Acasa"
           );
            Activitate a2 = new Activitate(
               "Examen SGBD", facultate,
               DateTime.Now.AddDays(10), DateTime.Now.AddDays(30),
               prioritate: 5,
               descriere: "Pregatire examen Baze de Date"
           );
            Activitate a3 = new Activitate(
                "Raport lunar", munca,
                DateTime.Now, DateTime.Now.AddDays(3),
                prioritate: 3,
                descriere: "Pregatire raport activitate lunara"
            );
            Activitate a4 = new Activitate(
                "Alergare parc", personal,
                DateTime.Now, DateTime.Now.AddHours(2),
                prioritate: 2,
                locatie: "Parcul Liniei"
            );
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);

            // Test operatori < > (compara pe prioritate)
            Console.WriteLine($"\nProiect C# (P:{a1.Prioritate}) > Alergare (P:{a4.Prioritate})? {a1 > a4}"); // true
            Console.WriteLine($"Raport (P:{a3.Prioritate}) < Examen BD (P:{a2.Prioritate})? {a3 < a2}");      // true

            // Test ++ si --
            Console.WriteLine($"\nInainte de ++: Prioritate a3 = {a3.Prioritate}");
            a3++;
            Console.WriteLine($"Dupa ++: Prioritate a3 = {a3.Prioritate}");
            a3--;
            a3--;
            Console.WriteLine($"Dupa doua --: Prioritate a3 = {a3.Prioritate}");

            // Test cast explicit la string
            string rezumat = (string)a1;
            Console.WriteLine($"\nCast la string: {rezumat}");

            // Test metode de prelucrare
            Console.WriteLine($"\nActivitatea '{a1.Titlu}' este in termen? {a1.esteInTermen()}");
            Console.WriteLine($"Durata estimata: {a1.DurataEstimata().Days} zile");
            Console.WriteLine($"Este urgenta? {a3.EsteUrgenta()}");

            // Test marcare finalizata
            a4.MarcheazaFinalizata();
            Console.WriteLine($"\nDupa finalizare: {a4}");

            // Test ICloneable pe Activitate
            Activitate copieA1 = (Activitate)a1.Clone();
            Console.WriteLine($"\nClona activitate: {copieA1}");
            copieA1.Titlu = "Proiect C# - COPIE";
            Console.WriteLine($"Original: {a1.Titlu}");
            Console.WriteLine($"Copie modificata: {copieA1.Titlu}");
            #endregion

            #region Testare Proiect
            Console.WriteLine("\n--- Creare proiect ---");
            Proiect proiectFacultate = new Proiect(
                "Semestru 2 - 2025/2026", facultate,
                new DateTime(2026, 6, 15),
                "Toate activitatile din semestrul 2"
            );
            // Adaugare activitati cu operatorul +
            proiectFacultate = proiectFacultate + a1;
            proiectFacultate = proiectFacultate + a2;
            proiectFacultate = proiectFacultate + a3;
            proiectFacultate = proiectFacultate + a4;

            Console.WriteLine(proiectFacultate);
            Console.WriteLine($"Procent finalizare: {proiectFacultate.ProcentFinalizare:F1}%");

            // Test indexer numeric
            Console.WriteLine($"\nActivitatea [0]: {proiectFacultate[0]}");
            Console.WriteLine($"Activitatea [1]: {proiectFacultate[1]}");

            // Test indexer dupa titlu
            Activitate gasita = proiectFacultate["Examen BD"];
            if (gasita != null)
                Console.WriteLine($"Gasit dupa titlu: {gasita}");

            // Test sortare dupa prioritate
            Console.WriteLine("\n--- Sortare dupa prioritate (descrescator) ---");
            proiectFacultate.SorteazaDupaPrioritate();
            for (int i = 0; i < proiectFacultate.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {proiectFacultate[i].sumar()}");
            }

            // Test sortare dupa data
            Console.WriteLine("\n--- Sortare dupa data (crescator) ---");
            proiectFacultate.SorteazaDupaDataStart();
            for (int i = 0; i < proiectFacultate.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {proiectFacultate[i].sumar()}");
            }

            // Test filtrare dupa status
            Console.WriteLine("\n--- Activitati finalizate ---");
            Activitate[] finalizate = proiectFacultate.FiltreazaDupaStatus(StatusActivitate.Finalizata);
            Console.WriteLine($"Numar activitati finalizate: {finalizate.Length}");
            foreach (var act in finalizate)
                Console.WriteLine($"  - {act}");

            // Test activitate prioritara
            Activitate prioritara = proiectFacultate.ActivitatePrioritara();
            Console.WriteLine($"\nActivitate cu prioritate maxima: {prioritara}");

            // Test operator - (eliminare activitate)
            Console.WriteLine($"\nInainte de eliminare: {proiectFacultate.Count} activitati");
            proiectFacultate = proiectFacultate - a4;
            Console.WriteLine($"Dupa eliminare '{a4.Titlu}': {proiectFacultate.Count} activitati");

            // Test este in intarziere
            Console.WriteLine($"Proiectul e in intarziere? {proiectFacultate.EsteInIntarziere()}");

            // Test ICloneable pe Proiect (deep copy)
            Proiect copieProiect = (Proiect)proiectFacultate.Clone();
            Console.WriteLine($"\nClona proiect: {copieProiect}");
            #endregion

            #region Test Export
            Console.WriteLine("\n--- Export Text ---");
            Console.WriteLine(a1.ExportText());

            Console.WriteLine("\n--- Export XML ---");
            Console.WriteLine(a1.ExportXML());

            Console.WriteLine("\n--- Export Proiect XML ---");
            Console.WriteLine(proiectFacultate.ExportXML());
            #endregion

           
            #region Test AGENDA(fara DELEGATE/EVENT)
            Console.WriteLine("\n\n=== TEST AGENDA  ===\n");

            AgendaActivitati agenda = new AgendaActivitati();
            Console.WriteLine("--- Adaugam domenii  ---");
            agenda.AdaugaDomeniu(facultate);
            agenda.AdaugaDomeniu(munca);
            agenda.AdaugaDomeniu(personal);

            Console.WriteLine("\n--- Adaugam activitati ---");
            Activitate act1 = new Activitate("Seminar JAVA", facultate,
                DateTime.Now, DateTime.Now.AddDays(7), 4, "Pregatire seminar");
            Activitate act2 = new Activitate("Meeting echipa", munca,
                DateTime.Now.AddDays(1), DateTime.Now.AddDays(1).AddHours(2), 5);
            Activitate act3 = new Activitate("Sala fitness", personal,
                DateTime.Now, DateTime.Now.AddHours(2), 2, "Antrenament saptamanal");

            agenda.AdaugaActivitate(act1);
            agenda.AdaugaActivitate(act2);
            agenda.AdaugaActivitate(act3);

            Console.WriteLine($"\n--- Starea agendei: {agenda} ---");

            // Test sortare
            Console.WriteLine("\n--- Activitati sortate dupa prioritate ---");
            List<Activitate> dupaP = agenda.SorteazaActivitateDupaPrioritate();
            foreach (Activitate a in dupaP)
                Console.WriteLine($"  P:{a.Prioritate} - {a.Titlu}");

            // Test filtrare
            Console.WriteLine("\n--- Activitati din domeniul Facultate ---");
            List<Activitate> dinFacultate = agenda.FiltreazaDupaDomeniu(facultate);
            foreach (Activitate a in dinFacultate)
                Console.WriteLine($"  - {a.Titlu}");

            // Test statistici
            Console.WriteLine("\n--- Statistici per domeniu ---");
            Dictionary<string, int> stats = agenda.StatisticiPerDomeniu();
            foreach (var pereche in stats)
                Console.WriteLine($"  {pereche.Key}: {pereche.Value} activitati");

            // Test marcare finalizata 
            Console.WriteLine("\n--- Marcam activitate finalizata ---");
            agenda.MarcheazaFinalizata(act3.Id);

            // Test statistici per status
            Console.WriteLine("\n--- Statistici per status ---");
            Dictionary<StatusActivitate, int> statsStatus = agenda.StatisticiPerStatus();
            foreach (var pereche in statsStatus)
                Console.WriteLine($"  {pereche.Key}: {pereche.Value}");

            // Test salvare/restaurare fisier
            Console.WriteLine("\n--- Test salvare in fisier ---");
            string caleFisier = "agenda_test.txt";
            agenda.SalveazaInFisier(caleFisier);
            Console.WriteLine($"Fisier salvat: {caleFisier}");

            // Test export XML
            Console.WriteLine("\n--- Export XML ---");
            string caleXML = "agenda_test.xml";
            agenda.SalveazaInFisierXML(caleXML);
            Console.WriteLine($"XML salvat: {caleXML}");

            // Test sterger
            Console.WriteLine("\n--- Stergem o activitate ---");
            agenda.StergeActivitate(act2.Id);
            Console.WriteLine($"Activitati ramase: {agenda.TotalActivitati}");

            // Test proiect in agenda
            Console.WriteLine("\n--- Adaugam proiect in agenda ---");
            Proiect proiectTest = new Proiect("Proiect Semestrial", facultate,
                new DateTime(2026, 6, 1), "Proiect de testare");
            proiectTest.AdaugaActivitate(act1);
            agenda.AdaugaProiect(proiectTest);

            Console.WriteLine($"\nStare finala: {agenda}");
            Console.WriteLine("\n=== Toate testele finalizate cu succes! ===");
            #endregion
            
        }
    }
}
