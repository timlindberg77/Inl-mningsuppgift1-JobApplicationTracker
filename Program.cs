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
            bool keepProgramAlive = true; //true or false för att ha en whileloop för menyn
            JobManager manage = new JobManager();
            TestData.AddSampleApplications(manage);
            while (keepProgramAlive)
            {
                MenyFunktioner.Menu();
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

                //💬 Reflektionsfrågor(för inlämning)
                //Besvara kort i en separat textfil:
                //Hur hjälpte LINQ dig att skriva renare kod?
                //Vilken del av projektet var mest utmanande, och hur löste du den?

            }
        }
}
}
