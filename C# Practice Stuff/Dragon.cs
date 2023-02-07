using System;

namespace Program
{
    public class Dragon
    {
        //fields
        string color;
        int age;
        string size;

        //Properties
        public string Color {get; set;}
        public int Age {get; set;}
        public string Size {get; set;}

        public Dragon()
        {
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