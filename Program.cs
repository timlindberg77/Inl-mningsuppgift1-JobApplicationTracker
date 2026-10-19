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
            JobManager manage = new JobManager(); //objekt
            TestData.AddSampleApplications(manage);
            while (keepProgramAlive)
            {
                MenyFunktioner.Menu();
                string menyUserAnswer = Console.ReadLine()!;
                
                switch (menyUserAnswer)
                {
                    case "1":
                        manage.AddJob();
                        break;

                    case "2":
                        manage.ShowAll();
                        break;

                    case "3":
                        manage.ShowByStatus();
                        break;

                    case "4":
                        manage.ShowByDate();
                        break;

                    case "5":
                        manage.ShowStatistics();
                        break;

                    case "6":
                        manage.UpdateStatus();
                        break;

                    case "7":
                        manage.RemoveApplication();
                        break;

                    case "8":
                        keepProgramAlive = false;
                        break;

                    default:
                        Console.WriteLine($"{menyUserAnswer} är inte ett alternativ ");
                        break;
                    
                }
                if (keepProgramAlive)
                {
                    MenyFunktioner.MenuClear();
                }

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
