using chess.model.Others;
using chess.pattern;
using System.Collections.Generic;


namespace chess.model
{
    public class Model : Observable, IModel
    {
        private Board _board; // the game board
        private Color _turn; // the nnext player to play
        public List<Point> _points; // the option points on the board

        public Model() : base()
        {
            _board = new Board();
            _turn = Color.white;
            _points = new List<Point>();
        }

        public void MovePiece(Point pointS, Point pointD)
        {
            bool win = false;
            if (_board.GetPiece(pointD) != null && _board.GetPiece(pointD).GetChess().Equals(Chess.king))
            {
                win = true;
            }

            _board.MovePiece(pointS, pointD);
            if (_turn == Color.black)
                _turn = Color.white;
            else
                _turn = Color.black;

            _points.Clear();

            base.Notify("board", this);

            if(win)
            {
                Color player;
                if (_turn == Color.black)
                    player = Color.white;
                else
                    player = Color.black;
                base.Notify("win " + player.ToString(), this);
            }
        }

        public void ComputePoints(Point point)
        {
            if (_board.GetPiece(point)!=null && _board.GetPiece(point).Color.Equals(_turn))
                _points = _board.ComputePoints(point);
            else
                _points.Clear();

            base.Notify("points", this);
        }

        public List<Point> GetPoints()
        {
            return _points;
        }

        public Board GetBoard()
        {
            return _board;
        }
    
        public void Retry()
        {
            _board = new Board();
            _turn = Color.white;
            _points = new List<Point>();
        }
    }
}
