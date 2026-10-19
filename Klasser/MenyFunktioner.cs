using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift1_JobApplicationTracker.Klasser
{
    public class MenyFunktioner
    {
        public static void MenuClear()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Tryck enter för att fortsätta");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
        }
        public static void Menu()
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
        }
        public static void Program()
        {
            bool keepProgramAlive = true; //true or false för att ha en whileloop för menyn
            JobManager manage = new JobManager(); //objekt
            TestData.AddSampleApplications(manage);
            while (keepProgramAlive)
            {
                Menu();
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
                    MenuClear();
                }
            }
        }
    }
}
