using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    
    class Program
    {        
        public static void Main(string[] args)
        {  
            //Room initialization

            Room room0;
            Room room1;
            Room room2;
            Room room3;

            Room[] map;
                                                                                                                                                                             // N,  S,  E,  W
            room0 = new Room("Home", "A homely cave all to yourself.  To the NORTH lies the exit to your cave.  Hanging across this exit is a curtain of woven morning glory.", 1, -1, -1, -1);
            room1 = new Room("Home Hall", "You are in your hallway.  It's spacious, almost as wide as your cave itself.  This passage leads NORTH to the outside world.  Birds can be heard outside, even from here.  To the SOUTH is the entrance to your cave.  Hanging across the entrance is a curtain of woven morning glory.", 2, 0, -1, -1);
            room2 = new Room("Outside - Home", "This is the clearing outside of your home.  Birds are singing, flowers are blooming, and a few paths lie before you.  To the SOUTH is the entrace to your cave.  There are pathways to the EAST and WEST.", -1, 1, 3, 4);
            

            Dragon user = Start();
            string input;

            Console.WriteLine($"Welcome, {user.Name}.  Your journey begins now.");

            Console.WriteLine($"You awake in your den.  {room0.Description}");


            // Basic input capture with a loop to quit.
            do {   
                Console.Write("> ");
                input = Console.ReadLine();
                Console.WriteLine($"You entered '{input}'.");
            } while (input != "q");
        }

         

        public static Dragon Start()
        {
            Console.WriteLine("You are a dragon.  Tell me about yourself.");

            //Prompt the user for the stats that will be used to create their dragon, and give them some fluff back.

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
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Dragon user = new Dragon(name, color, age, size);
            Console.Clear();
            return user;

            
        }
    }

}