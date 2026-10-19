using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using static Inlämningsuppgift1_JobApplicationTracker.Klasser.JobApplication;

namespace Inlämningsuppgift1_JobApplicationTracker.Klasser
{
    public class JobManager
    {

        //Applications | List<JobApplication> - Samling av alla ansökningar
        public List<JobApplication> Applications = new List<JobApplication>();
        public void AddJob() //lägger till en ny ansökan
        {
            var newApplication = new JobApplication();
            Console.WriteLine("Företag: ");
            newApplication.CompanyName = Console.ReadLine()!;

            Console.WriteLine("Befattning: ");
            newApplication.PositionTitle = Console.ReadLine()!;

            Console.WriteLine("Önskad lön (kr): ");
            int salary;
            while (!int.TryParse(Console.ReadLine(), out salary) || salary <= 0)
            {
                Console.WriteLine("Ogiltigt, skriv ett heltal: ");
            }
            newApplication.SalaryExpectation = salary;

            newApplication.Status = ApplicationStatus.Applied; // ny ansökan börjar som Applied
            newApplication.ApplicationDate = DateTime.Today;   // skickad idag

            Applications.Add(newApplication);
            Console.WriteLine("Ansökan tillagd!");

        }
        public void UpdateStatus() // ändrar status på en befintlig ansökan
        {
            Console.WriteLine("Vilket företag vill du uppdatera?");
            string userInput = Console.ReadLine()!;
            //Linq som söker efter ansökan där companyname matchar och ignorerar stora/små bokstäver
            var matchingApplication = Applications.FirstOrDefault(application => application.CompanyName.Equals(userInput, StringComparison.OrdinalIgnoreCase));
            
            if (matchingApplication == null) //Ifall inget userINput inte matcher med någon companyname
            {
                Console.WriteLine("Hittade ingen matchande ansökan");
                return;
            }

            var statuses = Enum.GetValues<ApplicationStatus>();
            for (int statusIndex = 0; statusIndex < statuses.Length; statusIndex++) //for loop som skriver ut Enum värden med ökat index värde så det startar på 1 och ej 0
            {
                Console.WriteLine($"{statusIndex + 1}: {statuses[statusIndex]}");
            }

            Console.WriteLine("Välj en ny status");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= statuses.Length) //gör så att svar utanför 1-4 är ogiltiga och svar som inte är ett nummer får värdet 0
            {
                matchingApplication.Status = statuses[choice - 1];
                
                if (matchingApplication.Status != ApplicationStatus.Applied)
                {
                    matchingApplication.ResponseDate = DateTime.Today;//uppdaterar status och lägger till ny tid
                }

                else
                {
                    matchingApplication.ResponseDate = null; //Behåller status och uppdaterar ej datum
                    
                }
                Console.WriteLine("Status uppdaterad");
            }
            else
            {
                Console.WriteLine("Ogilitgt");
            }
        }
        public void ShowAll() // visar alla ansökningar
        {
            if (Applications.Count == 0)
            {
                Console.WriteLine("Finns inga ansökan");
                return;
            }
            foreach (var application in Applications)
            {
                Console.WriteLine(application.GetSummary()); //Loop som använder JobApplication metoden
            }
            
        }

        public void ShowByStatus() // filtrerar med LINQ efter status(VG del)
        {
            if (Applications.Count == 0)
            {
                Console.WriteLine("Finns inga ansökan");
                return;
            }

            var sortedApplication = Applications.OrderBy(application => application.Status);

            foreach (var application in sortedApplication)
            {
                Console.WriteLine(application.GetSummary());
            }
        }

        public void ShowStatistics() // visar statistik med LINQ(Count, Average, OrderBy, Where) (VG del)
        {
            if (Applications.Count == 0)
            {
                Console.WriteLine("Finns inga ansökan");
                return;
            }
            foreach (var status in Enum.GetValues<ApplicationStatus>())
            {
                int count = Applications.Count(application => application.Status == status);
                Console.WriteLine($" {status}. {count}");
            }

            var interviews = Applications.Where(a => a.Status == ApplicationStatus.Interview);
            Console.WriteLine($"Antal intervjuer: {interviews.Count()}");

            var ordered = Applications.OrderBy(application => application.ApplicationDate);
            Console.WriteLine($"Äldsta ansökan: {ordered.First().CompanyName} ({ordered.First().ApplicationDate:yyyy-MM-dd})");

            var averageResponseTime = Applications
            .Where(a => a.ResponseDate != null)
            .Average(a => (a.ResponseDate - a.ApplicationDate)?.TotalDays);
            if (averageResponseTime.HasValue)
            {
                Console.WriteLine($"Genomsnittlig svarstid: {averageResponseTime.Value:F1} dagar");
            }
            else
            {
                Console.WriteLine("Genomsnittlig svarstid: inga svar än.");
            }
        }

        public void RemoveApplication() //Ta bort en ansökan
        {
            if (Applications.Count == 0)
            {
                Console.WriteLine("Finns inga ansökan");
                return;
            }
            Console.WriteLine("Vilket företag vill du ta bort?");
            string userInput = Console.ReadLine()!;
            //Linq som söker efter ansökan där companyname matchar och ignorerar stora/små bokstäver
            var matchingApplication = Applications.FirstOrDefault(application => application.CompanyName.Equals(userInput, StringComparison.OrdinalIgnoreCase));

            if (matchingApplication == null) //Ifall inget userINput inte matcher med någon companyname
            {
                Console.WriteLine("Hittade ingen matchande ansökan");
                return;
            }
            else
            {
                Applications.Remove(matchingApplication);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ansökan borttagen");
                Console.ResetColor();
            }
        }
        public void ShowByDate()   //Skapa ett extra filter, t.ex. “Visa ansökningar utan svar äldre än 14 dagar”
        {
            if (Applications.Count == 0)
            {
                Console.WriteLine("Finns inga ansökan");
                return;
            }
            var ordered = Applications.OrderBy(application => application.ApplicationDate);
            foreach (var application in ordered)
            {
                if (application.ResponseDate == null && application.GetDaysSinceApplied() >= 14)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(application.GetSummary());
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(application.GetSummary());
                }       
            }
        }
    }
}



