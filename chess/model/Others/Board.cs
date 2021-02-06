using chess.model.Others;
using System.Collections.Generic;

namespace chess.model
{
    public class Board
    {
        // Board:
        // this class represent the logic board

        public Piece[,] Pieces { get; } // matrix of pieces on the board

        public Board()
        {
            Pieces = new Piece[8, 8];

            Pieces[0, 0] = new Rook(Color.black, new Point(0, 0));
            Pieces[0, 1] = new Knight(Color.black, new Point(0, 1));
            Pieces[0, 2] = new Bishop(Color.black, new Point(0, 2));
            Pieces[0, 3] = new Queen(Color.black, new Point(0, 3));
            Pieces[0, 4] = new King(Color.black, new Point(0, 4));
            Pieces[0, 5] = new Bishop(Color.black, new Point(0, 5));
            Pieces[0, 6] = new Knight(Color.black, new Point(0, 6));
            Pieces[0, 7] = new Rook(Color.black, new Point(0, 7));

            Pieces[7, 0] = new Rook(Color.white, new Point(7, 0));
            Pieces[7, 1] = new Knight(Color.white, new Point(7, 1));
            Pieces[7, 2] = new Bishop(Color.white, new Point(7, 2));
            Pieces[7, 3] = new Queen(Color.white, new Point(7, 3));
            Pieces[7, 4] = new King(Color.white, new Point(7, 4));
            Pieces[7, 5] = new Bishop(Color.white, new Point(7, 5));
            Pieces[7, 6] = new Knight(Color.white, new Point(7, 6));
            Pieces[7, 7] = new Rook(Color.white, new Point(7, 7));

            for (int i = 0; i < 8; i++)
            {
                Pieces[1, i] = new Pawn(Color.black, new Point(1, i));
                Pieces[6, i] = new Pawn(Color.white, new Point(6, i));
            }

            Piece.Board = this;
        }

        // get the piece in the specific point on the board
        public Piece GetPiece(Point point)
        {
            if (point.I < 0 || point.J < 0 || point.I >= 8 || point.J >= 8)
                return null;

            return Pieces[point.I, point.J];
        }

        // move piece from source point to destination point
        public void MovePiece(Point pointS, Point pointD)
        {
            if (pointS.I < 0 || pointS.J < 0 || pointS.I >= 8 || pointS.J >= 8)
                return;
            if (pointD.I < 0 || pointD.J < 0 || pointD.I >= 8 || pointD.J >= 8)
                return;

            GetPiece(pointS).Point =  pointD;
            Pieces[pointD.I, pointD.J] = GetPiece(pointS);
            Pieces[pointS.I, pointS.J] = null;

            if(GetPiece(pointD).GetChess().Equals(Chess.pawn))
            {
                if(pointD.I == 0)
                {
                    Pieces[pointD.I, pointD.J] = new Queen(Color.white, pointD); ;
                }
                else if (pointD.I == 7)
                {
                    Pieces[pointD.I, pointD.J] = new Queen(Color.black, pointD); ;
                }
            }
        }

        // compute the points the the piece in the specific point can move to
        public List<Point> ComputePoints(Point point)
        {
            if (point.I < 0 || point.J < 0 || point.I >= 8 || point.J >= 8)
                return null;

            return Pieces[point.I, point.J].ComputePoints();
        }
    }
}
