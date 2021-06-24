using System;
using System.Collections.Generic;
using System.Text;

namespace defaultmethods
{
    public interface ICorrupt
    {
        public void BlackCard()
        {
            Console.WriteLine("spending money ...");
        }

        public void SpendLikeCrazy()
        {
            Console.WriteLine("Restaurants, parties, vacations, ...");
        }
    }
}
