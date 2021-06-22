using System;
using System.Collections.Generic;
using System.Text;

namespace state
{
    public class Package
    {

        private PackageState state = new OrderedState();

        public PackageState GetState()
        {
            return this.state;
        }

        public void SetState(PackageState state)
        {
            this.state = state;
        }

        public void PreviousState()
        {
            this.state.Prev(this);
        }

        public void NextState()
        {
            this.state.Next(this);
        }

        public void PrintStatus()
        {
            this.state.PrintStatus();
        }
    }
}
