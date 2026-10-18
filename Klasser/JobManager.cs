using System;
using System.Collections.Generic;
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
            var job = new JobApplication();
            Console.Write("Företag: ");
            job.CompanyName = Console.ReadLine()!;

            Console.Write("Befattning: ");
            job.PositionTitle = Console.ReadLine()!;

            Console.Write("Önskad lön (kr): ");
            job.SalaryExpectation = int.Parse(Console.ReadLine()!);

            job.Status = ApplicationStatus.Applied; // ny ansökan börjar som Applied
            job.ApplicationDate = DateTime.Today;   // skickad idag

            Applications.Add(job);
            Console.WriteLine("Ansökan tillagd!");

        }
        public static void UpdateStatus() // ändrar status på en befintlig ansökan
        {

        }
        public static void ShowAll() // visar alla ansökningar
        {

        }

        public static void ShowByStatus() // filtrerar med LINQ efter status(VG del)
        {

        }

        public static void ShowStatistics() // visar statistik med LINQ(Count, Average, OrderBy, Where) (VG del)
        {

        }
    }
}



