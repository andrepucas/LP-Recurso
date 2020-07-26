namespace VirusSim
{
    public class Coords
    {
        public int X {get ;}
        public int Y {get ;}

        public Coords(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X,2},{Y,2})";
        }
    }
}