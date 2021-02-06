using chess.model.Enums;
using chess.model.Others;
using System.Collections.Generic;

namespace chess.model
{
    public class Bishop:Piece
    {
        // Bishop:
        // this class represent a bishop piece

        public Bishop(Color color, Point point) : base(color, point) { }

        public override Chess GetChess()
        {
            return Chess.bishop;
        }

        public override List<Point> ComputePoints()
        {
            List<Point> points = new List<Point>();

            points.AddRange(RunSlant(Direction.ul));
            points.AddRange(RunSlant(Direction.ur));
            points.AddRange(RunSlant(Direction.dl));
            points.AddRange(RunSlant(Direction.dr));

            return points;
        }
    }
}
