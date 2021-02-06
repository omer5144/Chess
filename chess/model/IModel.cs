using chess.model.Others;
using System.Collections.Generic;

namespace chess.model
{
    public interface IModel 
    {
        // IModel:
        // this interface represent the functionality of the game logic

        // action methods
        public void MovePiece(Point pointS, Point pointD); // move piece from source point to destination point on the board
        public void ComputePoints(Point point); // compute the option points that the piece in the specific point on the board can move to
        public void Retry(); // retry the board state

        // get methods
        public List<Point> GetPoints(); // get the points computed
        public Board GetBoard(); // get the board computed

    }
}
