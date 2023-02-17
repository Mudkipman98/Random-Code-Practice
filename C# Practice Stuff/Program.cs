using System;
using System.Collections.Generic;

namespace Program
{
    
    class Program
    {        
        public static void Main(string[] args)
        {  
            //Room initialization

            Room room0;
            Room room1;

            Room[] map;
                                                                                                                                                                             // N,  S,  E,  W
            room0 = new Room("Home", "A homely cave all to yourself.  To the NORTH lies the exit to your cave.  Hanging across this exit is a curtain of woven morning glory.", 1, -1, -1, -1);
            room1 = new Room("Home Hall", "You are in your hallway.  It's spacious, almost as wide as your cave itself.  This passage leads NORTH to the outside world.  Birds can be heard outside, even from here.  To the SOUTH is the entrance to your cave.  Hanging across the entrance is a curtain of woven morning glory.", 2, 0, -1, -1);

            Dragon user = Start();
            // Console.WriteLine(user.Name); //NEED TO FIGURE OUT THE ISSUE WITH SCOPE HERE.  
            //Because the Dragon user is static I can only call it using the type, but what if I need multiple dragons?  
            //I get the issue with using static for the main method when the instantialization isn't static, 
            //but not why methods in other files can't pull this dragon object into them.
            // It seems like as long as the methods are accepting arguments that match the same type
            //and not directly referring to members of the Dragon object, it's fine, just means more work in implementing those methods.  
            //There's got to be a good way to automate that.  Maybe with some kind of declaration in main?

            Console.WriteLine($"Welcome, {user.Name}.  Your journey begins now.");

            Console.WriteLine("You awake in your den.  It feels like morning, but you're deep underground.");
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