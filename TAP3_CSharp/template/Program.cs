using System;

namespace template
{
    class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Cricket();
            game.Play();
            Console.WriteLine();
            game = new Football();
            game.Play();
        }
    }
}
