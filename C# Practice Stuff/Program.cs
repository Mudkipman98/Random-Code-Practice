using System;

namespace Program
{
    
    class Program
    {
        
        public Dragon user = Start();
        
        public void Main(string[] args)
        {  
            
            Console.WriteLine(user.Name); //NEED TO FIGURE OUT THE ISSUE WITH SCOPE HERE, for some reason the dragon object has to be within the scope of Main, and I can't figure out why.  So other classes can't access that dragon object, and that's a big problem for organization.
            
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

            Dragon user = new Dragon(name, color, age, size);
            return user;


        }
    }

}