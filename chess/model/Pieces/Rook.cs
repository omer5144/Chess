using chess.model.Enums;
using chess.model.Others;
using System.Collections.Generic;

namespace chess.model
{
    public class Rook : Piece
    {
        // Rook:
        // this class represent a rook piece

        public Rook(Color color, Point point) : base(color, point) { }

        public override Chess GetChess()
        {
            return Chess.rook;
        }

        public override List<Point> ComputePoints()
        {
            List<Point> points = new List<Point>();

            points.AddRange(RunStraight(Direction.up));
            points.AddRange(RunStraight(Direction.down));
            points.AddRange(RunStraight(Direction.left));
            points.AddRange(RunStraight(Direction.right));

            return points;
        }
    }
}
