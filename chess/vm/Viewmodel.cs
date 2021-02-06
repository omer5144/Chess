using chess.model;
using chess.pattern;
using System.Collections.Generic;
using System.Drawing;

namespace chess.vm
{
    public class Viewmodel : Observable, IViewmodel
    {
        private readonly IModel _model; // the game logic
        private string[,] _board; // the board in string matrix representation
        private readonly List<Point> _points; // the option points on the board

        public Viewmodel(IModel model)
        {
            _model = model;
            _points = new List<Point>();
        }

        public void ComputeBoard()
        {
            _board = new string[8, 8];
            Piece[,] board = _model.GetBoard().Pieces;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i, j] == null)
                        _board[i, j] = "none";
                    else
                        _board[i, j] = board[i, j].Color + "_" + board[i, j].GetChess();
                }
            }

            _points.Clear();
            base.Notify("board", this);
        }

        public void ComputePoints(Point point)
        {
            _model.ComputePoints(new model.Others.Point(point));
            base.Notify("points", this);
        }

        public string[,] GetBoard()
        {
            return _board;
        }

        public List<Point> GetPoints()
        {
            return _points;
        }

        public void MovePiece(Point pointS, Point pointD)
        {
            _model.MovePiece(new model.Others.Point(pointS), new model.Others.Point(pointD));
        }

        public void Retry()
        {
            _model.Retry();
        }

        public void Update(string data, Observable o)
        {
            if(data.Equals("points"))
            {
                _points.Clear();
                List<model.Others.Point> points;
                points = _model.GetPoints();
                foreach (model.Others.Point point in points)
                {
                    _points.Add(new Point(point.I, point.J));
                }
            }
            else if(data.Equals("board"))
            {
                _points.Clear();
                List<model.Others.Point> points;
                points = _model.GetPoints();
                foreach (model.Others.Point point in points)
                {
                    _points.Add(new Point(point.I, point.J));
                }
            }
            else if(data.StartsWith("win"))
            {
                base.Notify(data, this);
            }
        }
    }
}
