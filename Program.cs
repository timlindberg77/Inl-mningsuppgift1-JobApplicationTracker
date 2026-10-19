using Inlämningsuppgift1_JobApplicationTracker.Klasser;
using System.Data;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace Inlämningsuppgift1_JobApplicationTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //⚙️ Instruktioner
            //Skapa ett nytt C# Console Project.
            //Skapa minst två klasser:
            //JobApplication – representerar en enskild ansökan.
            //JobManager – ansvarar för att hantera alla ansökningar(listan, logik och LINQ).
            //I Program.cs ska du skapa ett menysystem som körs i en while-loop och använder switch för val.
            bool keepProgramAlive = true; //true or false för att ha en whileloop för menyn
            JobManager manage = new JobManager();
            //Implementera minst tre LINQ-operationer för att filtrera, sortera eller beräkna data.
            //Koden ska vara välstrukturerad, kommenterad, och enhetligt namngiven.
            //Projektet ska hanteras via Git & GitHub enligt kravspecifikationen nedan.
            while (keepProgramAlive)
            {
            Console.WriteLine($"Välkommen!\n" +
                $"1: Lägg till ny ansökan\n" +
                $"2: Visa alla ansökningar\n" +
                $"3: Filtrera ansökningar efter status\n" + // (LINQ) (VG del)
                $"4: Sortera ansökningar efter datum\n" + // (OrderBy) (VG del)
                $"5: Visa statistik\n" + //Totalt antal ansökningar, Antal per status (VG del), Genomsnittlig svarstid (VG del)
                $"6: Uppdatera status på en ansökan\n" +
                $"7: Ta bort en ansökan\n" +
                $"8: Avsluta programmet");

                string menyUserAnswer = Console.ReadLine()!;
                
                switch (menyUserAnswer)
                {
                    case "1":
                        manage.AddJob();
                        MenyFunktioner.MenuClear();
                        break;

                    case "2":
                        manage.ShowAll();
                        MenyFunktioner.MenuClear();
                        break;

                    case "3":
                        manage.ShowByStatus();
                        MenyFunktioner.MenuClear();
                        break;

                    case "4":
                        manage.ShowByDate();
                        MenyFunktioner.MenuClear();
                        break;

                    case "5":
                        manage.ShowStatistics();
                        MenyFunktioner.MenuClear();
                        break;

                    case "6":
                        manage.UpdateStatus();
                        MenyFunktioner.MenuClear();
                        break;

                    case "7":
                        manage.RemoveApplication();
                        MenyFunktioner.MenuClear();
                        break;

                    case "8":
                        keepProgramAlive = false;
                        break;

                    default:
                        Console.WriteLine($"{menyUserAnswer} är inte ett alternativ ");
                        break;
                    
                }

                //🕓 Minst 5 commits totalt, med tydliga meddelanden(Added JobManager class, Implemented LINQ filters, etc.).

                //📂 README.md ska finnas i repot, med:

                //Projektbeskrivning
                //Hur man kör programmet
                //Ditt namn och datum och reflektion(frågor finns längre ner här)


                //💡 Bonusnivå(VG)
                //För högre betyg :
                //Skapa ett extra filter, t.ex. “Visa ansökningar utan svar äldre än 14 dagar”

                //💬 Reflektionsfrågor(för inlämning)
                //Besvara kort i en separat textfil:
                //Hur hjälpte LINQ dig att skriva renare kod?
                //Vilken del av projektet var mest utmanande, och hur löste du den?

                //📦 Inlämning
                //Lämna in länken till ditt GitHub Repository i Learnpoint kommentarfältet.

                //Se till att repot är offentligt (Public) eller delat med läraren.

                //Kontrollera att du har:
                // ✅ Minst 3 branches
                // ✅ Minst 3 pull requests
                // ✅ README.md
                // ✅ Branch protection aktiv
            }
        }
}
}
