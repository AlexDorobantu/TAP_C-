﻿using System;
using System.Collections.Generic;
using System.Text;

namespace template
{
    public class Football : Game
    {
        protected override void EndPlay()
        {
            Console.WriteLine("Football Game Finished!");
        }

        protected override void Initialize()
        {
            Console.WriteLine("Football Game Initialized! Start playing.");
        }

        protected override void StartPlay()
        {
            Console.WriteLine("Football Game Started. Enjoy the game!");
        }

    }
}
