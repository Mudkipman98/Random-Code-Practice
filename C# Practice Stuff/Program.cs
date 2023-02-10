using System;

namespace Program
{
    
    public class Program
    {
        
        public Dragon user = new Dragon();
        
        public static void Main(string[] args)
        {  
            
            Start();
            

            



            //uncomment the below and fill in the argument for quick debugging
            // Console.WriteLine(user.Name);
            // Console.WriteLine(user.Color);
            // Console.WriteLine(user.Age);
            // Console.WriteLine(user.Size);
            // Console.WriteLine(user.HP);
        }

        public static void Start()
        {
            Console.WriteLine("You are a dragon.  Tell me about yourself.");

            //Prompt the user for the stats that will be used to create their dragon, and give them some fluff back.

            Console.Write("What is your name? ");
            user.Name = Tools.StrGetResponse();
            Console.Write($"Hello, {user.Name}.  What color are your scales? ");
            user.Color = Tools.StrGetResponse();
            Console.WriteLine($"Ah, {user.Color}.  A fine color indeed.");
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

        }
    }

}