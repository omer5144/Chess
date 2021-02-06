namespace chess.pattern
{
    public interface IObserver
    {
        // IObserver:
        // this interface represent an observer
        
        // when the observable notifies about change
        public void Update(string data, Observable o);
    }
}
