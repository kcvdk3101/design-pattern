using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subject
    {
        private readonly List<IObserver> _observers = new List<IObserver>(); 

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void DeleteObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(Subject subject, object arg)
        {
            _observers.ForEach((observer) => observer.Notify(subject, arg));
        }
    }
}
