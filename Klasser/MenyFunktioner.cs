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
    }
}
