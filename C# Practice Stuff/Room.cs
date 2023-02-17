namespace Program
{
    public class Room
    {
        private string name, description;
        private int n, s, e, w;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int N { get => n; set => n = value; }
        public int S { get => s; set => s = value; }
        public int E { get => e; set => e = value; }
        public int W { get => w; set => w = value; }

        public Room(string name, string description, int n, int s, int e, int w)
        {
            Name = name;
            Description = description;
            N = n;
            S = s;
            E = e;
            W = w;
        }
    }
}