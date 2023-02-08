using System;

namespace Program
{
    public class Dragon
    {
        //Properties
        public string Name { get; private set; }

        public string Color { get; protected set; }

        public int Age { get; set; }

        public string Size { get; set; }

        public int HP {get; set;}

        public Dragon(string name = "chungus", string color = "bungus", int age = 69, string size = "Small")
        {
            Name = name;
            Color = color;
            Age = age;
            Size = size;
            HP = Age*2;
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
            result = random.Next(1, 7);

            Console.WriteLine($"{Name} deals {result} to {target}!");
        }
    }
}
