using System.Collections.Generic;
using System.Drawing;
using chess.pattern;

namespace chess.vm
{
    public interface IViewmodel: IObserver
    {
        // IViewmodel:
        // this interface represent the functionality of the view-model

        public void Add(IObserver observer);
        public void Remove(IObserver observer);

        //action
        public void MovePiece(Point pointS, Point pointD); // move piece from source point to destination point on the board
        public void ComputePoints(Point point); // compute the option points that the piece in the specific point on the board can move to
        public void ComputeBoard(); // compute the board state (to string matrix)
        public void Retry(); // retry the board state

        //get
        public List<Point> GetPoints(); // get the points computed
        public string[,] GetBoard(); // get the board computed
    }
}
