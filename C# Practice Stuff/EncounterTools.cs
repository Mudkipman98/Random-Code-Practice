using System;

namespace Program
{
    public class EncounterTools
    {

        public static void EncounterStart()
        {
            DrawHUD();
        }


        public static void DrawHUD()
        {
            int hudWidth = 20;

            string topOrBottom = "O--------------------O";

            Dragon user = Program.user;

            Console.WriteLine(topOrBottom);
            Console.WriteLine($"| Name: {Program.user.Name}");
            Console.WriteLine($"| HP: {Program.user.HP}");
            Console.WriteLine(topOrBottom);
        }
    }
}