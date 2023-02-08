using System;

namespace Program
{
    
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("You are a dragon.  Tell me about yourself.");

            //Prompt the user for the stats that will be used to create their dragon.

            Console.Write("What is your name? ");
            string name = Tools.StrGetResponse();
            Console.Write($"Hello, {name}.  What color are your scales? ");
            string color = Tools.StrGetResponse();
            Console.WriteLine($"Ah, {color}.  A fine color indeed.");
            Console.Write("How old are you? ");
            int age = Tools.IntGetResponse();
            string size;

            switch (age)
            {
                case 0:
                    Console.WriteLine("Oh my!  Newly hatched, I see.  Be careful, young one.");
                    size = "Small";
                    break;
                case <= 5:
                    Console.WriteLine("Why, you've barely seen what the world has to offer.  Tread lightly, little one.");
                    size = "Medium";
                    break;
                case > 5:
                    Console.WriteLine("Thank you.");
                    size = "Large";
                    break;
                default:
            }

            Console.WriteLine("One moment while I understand you."); //Clunky phrasing, consider revising.

            Dragon user = new Dragon(name, color, age, size);

            Console.WriteLine("You find yourself in a cave.  There's a scavenger in front you, and they're brandishing a knife.  What do you do?");

            string firstChoice1 = Console.ReadLine().ToLower();
            string firstChoice2 = Console.ReadLine().ToLower();

            string[] firstChoice = new string[] {firstChoice1, firstChoice2};

            if(firstChoice[0] == "attack" && firstChoice[1] != "")
            {
                user.BreathAttack(firstChoice[1]);
            }
            else
            {
                Console.WriteLine("shid pood fard");
            }



            //uncomment the below and fill in the argument for quick debugging
            // Console.WriteLine(user.Name);
            // Console.WriteLine(user.Color);
            // Console.WriteLine(user.Age);
            // Console.WriteLine(user.Size);
            // Console.WriteLine(user.HP);
        }
    }

}