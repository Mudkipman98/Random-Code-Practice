using System;

namespace Program
{
    public class Dragon
    {
        //Properties
        public string Name {get; private set;}
        public string Color {get; protected set;}
        public int Age {get; set;}
        public string Size {get; set;}

        public Dragon(string name, string color, int age = 0, string size = "Small")
        {
            Name = name;
            Color = color;
            Age = age;
            Size = size;

        }

        public string Roar()
        {
            return "RAWR!";
        }

        public void BreathAttack(string target)
        {
            Console.WriteLine($"{Name} uses a breath attack on {target}!");

            int result;
            Random random = new Random();
            result = random.Next(1,7);

            Console.WriteLine($"{Name} deals {result} to {target}!");

            Console.WriteLine("Hey check it out, you merged from main!");
        }

    }
}