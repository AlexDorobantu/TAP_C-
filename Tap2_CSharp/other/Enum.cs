using System;
using System.Collections.Generic;
using System.Text;

namespace other
{
    public class Enum
    {

        enum Season {WINTER, SPRING, SUMMER, FALL};

        public static void Main(String[] args)
        {
            Season temporada;

            temporada = Season.SUMMER;

            switch (temporada)
            {
                case SUMMER:
                    Console.WriteLine("verano");
                    break;
                case FALL:
                    Console.WriteLine("otoño");
                    break;
                case SPRING:
                    Console.WriteLine("primavera");
                    break;
                case WINTER:
                    Console.WriteLine("invierno");
                    break;
            }
            
            Season[] lista = Season.values();
            foreach (Season s in lista)
            {
                Console.WriteLine(s);
            }

        }
    }
}
