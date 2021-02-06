using chess.model.Enums;
using chess.model.Others;
using System.Collections.Generic;

namespace chess.model
{
    public class Queen : Piece
    {
        // Queen:
        // this class represent a queen piece

        public Queen(Color color, Point point) : base(color, point) { }

        public override Chess GetChess()
        {
            return Chess.queen;
        }

        public override List<Point> ComputePoints()
        {
            List<Point> points = new List<Point>();

            points.AddRange(RunSlant(Direction.ul));
            points.AddRange(RunSlant(Direction.ur));
            points.AddRange(RunSlant(Direction.dl));
            points.AddRange(RunSlant(Direction.dr));
            points.AddRange(RunStraight(Direction.up));
            points.AddRange(RunStraight(Direction.down));
            points.AddRange(RunStraight(Direction.left));
            points.AddRange(RunStraight(Direction.right));

            return points;
        }
    }
}
