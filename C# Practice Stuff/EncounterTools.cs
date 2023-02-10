using System;

namespace Program
{
    public class EncounterTools
    {
        string topOrBottom = "O--------------------O";
        public bool EncounterStart(Dragon player, Object target)
        {
            DrawHUD(player);

            return true;
        }


        public void DrawHUD(Dragon player)
        {
            Console.WriteLine(topOrBottom);
            Console.WriteLine($"| Name: {player.Name}");
            Console.WriteLine($"| HP: {player.HP}");
            Console.WriteLine(topOrBottom);
        }

        public string CombatChoice()
        {
            Console.WriteLine(topOrBottom);
            Console.WriteLine("| (A) Attack");
            Console.WriteLine("| (B) Defend");
            Console.WriteLine("| (C) Run");
            Console.WriteLine(topOrBottom);

            string choice = Console.ReadLine().ToLower();

            while (choice != "a" || choice != "b" || choice != "c")
            {
                Console.WriteLine("Please enter an option: A, B, or C.");
                choice = Console.ReadLine().ToLower();
            }

            return choice;
        }
    }
}