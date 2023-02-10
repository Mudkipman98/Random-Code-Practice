using System;

namespace Program
{
    public class EncounterTools
    {

        Dragon user = Program.Dragon.user;

        public static void EncounterStart()
        {
            DrawHUD();
        }


        public void DrawHUD()
        {
            int hudWidth = 20;

            string topOrBottom = "O--------------------O";


            Console.WriteLine(topOrBottom);
            Console.WriteLine($"| Name: {Program.user.Name}");
            Console.WriteLine($"| HP: {Program.user.HP}");
            Console.WriteLine(topOrBottom);
        }
    }
}