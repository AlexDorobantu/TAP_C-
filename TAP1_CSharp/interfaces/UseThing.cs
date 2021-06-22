using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    public class UseThing
    {

        public static void Main(String[] args)
        {
            Thing c = new Thing();
            Sing(c);
            Dance(c);

            Musician music;
            Bop dance;

            music = c;
            dance = c;

            Console.WriteLine(music.Sing());
            Console.WriteLine(dance.Dance());

            music = ((Musician)(dance));
            Console.WriteLine(music.Sing());
        }
        
        public static void Sing(Musician m)
        {
            Console.WriteLine(m.Sing());
        }

        public static void Dance(Bop b)
        {
            Console.WriteLine(b.Dance());
        }
    }




}
