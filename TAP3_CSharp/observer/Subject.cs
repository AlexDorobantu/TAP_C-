using System;
using System.Collections.Generic;
using System.Text;

namespace observer
{
    public class Subject
    {

        private List<Observer> observers = new List<Observer>();

        private int state;

        public int GetState()
        {
            return this.state;
        }

        public void SetState(int state)
        {
            this.state = state;
            this.NotifyAllObservers(this.state);
        }

        public void Attach(Observer observer)
        {
            this.observers.Add(observer);
        }

        public void NotifyAllObservers(int state)
        {
            foreach (Observer observer in this.observers)
            {
                observer.Update(this.state);
            }

        }
    }
}
