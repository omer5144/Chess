namespace chess.model.Others
{
    public class Point
    {
        // Point:
        // this class represent a two dimension point

        public int I { get; set; }
        public int J { get; set; }

        public Point(int i, int j)
        {
            I = i;
            J = j;
        }

        public Point(System.Drawing.Point point)
        {
            I = point.X;
            J = point.Y;
        }
    }
}
