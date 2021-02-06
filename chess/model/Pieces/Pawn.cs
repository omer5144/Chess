using chess.model.Others;
using System.Collections.Generic;

namespace chess.model
{
    public class Pawn:Piece
    {
        // Pawn:
        // this class represent a pawn piece

        public Pawn(Color color, Point point) : base(color, point) { }

        public override Chess GetChess()
        {
            return Chess.pawn;
        }

        public override List<Point> ComputePoints()
        {
            List<Point> points = new List<Point>();

            if (Color == Color.black)
            {
                Point pointB = new Point(Point.I + 1, Point.J);
                if (Board.GetPiece(pointB) == null)
                {
                    points.Add(pointB);
                    pointB = new Point(Point.I + 2, Point.J);
                    if (Board.GetPiece(pointB) == null && Point.I == 1)
                    {
                        points.Add(pointB);
                    }
                }

                Point pointB1 = new Point(Point.I+1, Point.J + 1);
                Point pointB2 = new Point(Point.I+1, Point.J - 1);
                if (Board.GetPiece(pointB1) != null && !Board.GetPiece(pointB1).Color.Equals(Color))
                {
                    points.Add(pointB1);
                }
                if (Board.GetPiece(pointB2) != null && !Board.GetPiece(pointB2).Color.Equals(Color))
                {
                    points.Add(pointB2);
                }

            }
            else
            {
                Point pointW = new Point(Point.I - 1, Point.J);
                if (Board.GetPiece(pointW) == null)
                {
                    points.Add(pointW);
                    pointW = new Point(Point.I-2, Point.J);
                    if (Board.GetPiece(pointW) == null && Point.I == 6)
                    {
                        points.Add(pointW);
                    }
                }

                Point pointW1 = new Point(Point.I - 1, Point.J + 1);
                Point pointW2 = new Point(Point.I - 1, Point.J - 1);
                if (Board.GetPiece(pointW1) != null && !Board.GetPiece(pointW1).Color.Equals(Color))
                {
                    points.Add(pointW1);
                }
                if (Board.GetPiece(pointW2) != null && !Board.GetPiece(pointW2).Color.Equals(Color))
                {
                    points.Add(pointW2);
                }
            }

            return points;
        }
    }
}
