using System.Collections.Generic;
using chess.model.Enums;
using chess.model.Others;

namespace chess.model
{
    public abstract class Piece
    {
        // Piece:
        // this class represent a single piece on the board

        public static Board Board { get; set; }
        public Color Color { get; }
        public Point Point { get;  set; }

        protected Piece(Color color, Point point)
        {
            Color = color;
            Point = new Point(point.I, point.J);
        }

        // get the piece type of the piece
        abstract public Chess GetChess();

        // compute the points that this piece can move to
        abstract public List<Point> ComputePoints();

        // calculate the option points in this straight direction
        protected List<Point> RunStraight(Direction dir)
        {
            List<Point> points = new List<Point>();

            int init = 0;
            int final = 0;
            int step = 0;

            if(dir.Equals(Direction.up))
            {
                init = Point.I;
                step = 1;
                final = 8;
            }
            else if (dir.Equals(Direction.down))
            {
                init = Point.I;
                step = -1;
                final = -1;
            }
            else if (dir.Equals(Direction.right))
            {
                init = Point.J;
                step = 1;
                final = 8;
            }
            else if (dir.Equals(Direction.left))
            {
                init = Point.J;
                step = -1;
                final = -1;
            }

            for (int i = init + step; i != final; i += step)
            {
                Point point;
                if (dir.Equals(Direction.right) || dir.Equals(Direction.left))
                    point = new Point(Point.I, i);
                else
                    point = new Point(i, Point.J);

                if (Board.GetPiece(point) == null)
                {
                    points.Add(point);
                }
                else if (Board.GetPiece(point).Color.Equals(Color))
                {
                    break;
                }
                else
                {
                    points.Add(point);
                    break;
                }
            }

            return points;
        }

        // calculate the option points in this slant direction
        protected List<Point> RunSlant(Direction dir)
        {
            List<Point> points = new List<Point>();

            int stepX = 0;
            int stepY = 0;
            int initX = Point.I;
            int initY = Point.J;
            int finalX = 0;
            int finalY = 0;

            if (dir.Equals(Direction.ul))
            {
                stepX = -1;
                stepY = -1;
                finalY = -1;
                finalX = -1;
            }
            else if (dir.Equals(Direction.ur))
            {
                stepX = -1;
                stepY = 1;
                finalX = -1;
                finalY = -8;
            }
            else if (dir.Equals(Direction.dl))
            {
                stepX = 1;
                stepY = -1;
                finalX = 8;
                finalY = -1;
            }
            else if (dir.Equals(Direction.dr))
            {
                stepX = 1;
                stepY = 1;
                finalY = 8;
                finalX = 8;
            }

            initX += stepX;
            initY += stepY;
            while (!(initX == finalX || initY==finalY))
            {
                Point point = new Point(initX,initY);

                if (Board.GetPiece(point) == null)
                {
                    points.Add(point);
                }
                else if (Board.GetPiece(point).Color.Equals(Color))
                {
                    break;
                }
                else
                {
                    points.Add(point);
                    break;
                }

                initX += stepX;
                initY += stepY;
            }

            return points;
        }
    }
}
