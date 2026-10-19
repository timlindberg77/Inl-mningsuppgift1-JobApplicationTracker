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
    }
}
