using System;

namespace Program
{
    public class Dragon
    {
        //fields
        int age;
        string size;

        //Properties
        public string Name {get; private set;}
        public string Color {get; protected set;}
        public int Age {get; set;}
        public string Size {get; set;}

        public Dragon(string name, string color)
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

        public void BreathAttack()
        {
            Console.WriteLine();
        }

    }
}