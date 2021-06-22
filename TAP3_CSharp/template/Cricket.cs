using System;
using System.Collections.Generic;
using System.Text;

namespace template
{
    public class Cricket : Game
    {
        protected override void EndPlay()
        {
            Console.WriteLine("Cricket Game Finished!");
        }

        protected override void Initialize()
        {
            Console.WriteLine("Cricket Game Initialized! Start playing.");
        }

        protected override void StartPlay()
        {
            Console.WriteLine("Cricket Game Started. Enjoy the game!");
        }

    }
}
