using System.Collections.Generic;

namespace chess.pattern
{
    public abstract class Observable
    {
        // Observable:
        // this class represent an observable

        protected List<IObserver> _observers; // list ob observer for this observable

        public Observable()
        {
            _observers = new List<IObserver>();
        }

        // add an observer to list
        public void Add(IObserver observer)
        {
            _observers.Add(observer);
        }

        // remove an observer from list
        public void Remove(IObserver observer)
        {
            _observers.Add(observer);
        }

        // notify all observers about change
        public void Notify(string data, Observable o)
        {
            foreach(IObserver observer in _observers)
            {
                observer.Update(data, o);
            }
        }
    }
}
