using chess.model.Others;
using System.Collections.Generic;

namespace chess.model
{
    public class King : Piece
    {
        // King:
        // this class represent a king piece

        public King(Color color, Point point) : base(color, point) {}

        public override Chess GetChess()
        {
            return Chess.king;
        }

        public override List<Point> ComputePoints()
        {
            List<Point> pointsTemp = new List<Point>
            {
                new Point(Point.I + 1, Point.J),
                new Point(Point.I - 1, Point.J),
                new Point(Point.I, Point.J + 1),
                new Point(Point.I, Point.J - 1),
                new Point(Point.I + 1, Point.J + 1),
                new Point(Point.I - 1, Point.J - 1),
                new Point(Point.I - 1, Point.J + 1),
                new Point(Point.I + 1, Point.J - 1)
            };


            List<Point> points = new List<Point>();

            foreach (Point point in pointsTemp)
            {
                if (!(point.I >= 8 || point.I < 0 || point.J >= 8 || point.J < 0 || (Board.GetPiece(point) != null && Board.GetPiece(point).Color.Equals(Color))))
                    points.Add(point);
                
            }
            return points;
        }


    }
}
