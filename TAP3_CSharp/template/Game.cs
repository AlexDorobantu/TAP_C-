using System;
using System.Collections.Generic;
using System.Text;

namespace template
{
    public abstract class Game
    {
        protected abstract void Initialize();

        protected abstract void StartPlay();

        protected abstract void EndPlay();

        // template method
        public void Play()
        {
            // initialize the game
            Initialize();
            // start game
            StartPlay();
            // end game
            EndPlay();
        }
    }
}
