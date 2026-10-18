using System.Data;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
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
                        //Lägger till ansökan
                        break;

                    case "2":
                        //visar ansökan
                        break;

                    case "3":
                        //Filtrera ansökan
                        break;

                    case "4":
                        //Sortera ansökan
                        break;

                    case "5":
                        //visa statistik
                        break;

                    case "6":
                        //Uppdatera status
                        break;

                    case "7":
                        //ta bort ansökan
                        break;

                    case "8":
                        keepProgramAlive = false;
                        break;

                    default:
                        Console.WriteLine($"{menyUserAnswer} är inte ett alternativ ");
                        break;
                    
                }

                //🧮 LINQ (krav) (VG del)
                //Minst 3 LINQ-operationer ska användas i projektet.Exempel:

                //var interviews = Applications.Where(a => a.Status == Status.Interview);
                //var ordered = Applications.OrderBy(a => a.ApplicationDate);
                //var averageResponseTime = Applications
                //.Where(a => a.ResponseDate != null)
                //.Average(a => (a.ResponseDate - a.ApplicationDate)?.TotalDays);



                //🌿 GitHub & Versionshantering(krav)
                //Projektet ska hanteras i ett GitHub Repository med följande krav:

                //🏗️ Minst 3 grenar(branches)
                //T.ex.main, development, feature-linq, feature-menu, etc.

                //🔄 Minst 3 Pull Requests
                //Varje PR ska representera en tydlig del av arbetet(t.ex. “Lade till LINQ-filter”).

                //🔒 Branch Protection Rules ska vara aktiverade för main-grenen
                //Ingen push direkt till main utan PR.

                //🧩 Beskrivningar i PRs – varje Pull Request ska ha en kort sammanfattning av vad som lagts till/förändrats.

                //🕓 Minst 5 commits totalt, med tydliga meddelanden(Added JobManager class, Implemented LINQ filters, etc.).

                //📂 README.md ska finnas i repot, med:

                //Projektbeskrivning
                //Hur man kör programmet
                //Ditt namn och datum och reflektion(frågor finns längre ner här)


                //💡 Bonusnivå(VG)
                //För högre betyg :
                //Använd färger i konsolen(t.ex.grön = Offer, röd = Rejected)
                //ShowByStatus() – filtrerar ansökningar med LINQ efter status
                //ShowStatistics() – visar ansökningar statistik med LINQ(Count, Average, OrderBy, Where)
                //Skapa ett extra filter, t.ex. “Visa ansökningar utan svar äldre än 14 dagar”
                //Implementera enkel felhantering(t.ex.ogiltig input)
                //Strukturera klasserna i separata filer för extra ren kod


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
