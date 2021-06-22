using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    public class UseTalkative
    {
        public static void Main(String[] args)
        {
            Homer homer = new Homer();
            Bart bart = new Bart();
            Talkative[] springfield = new Talkative[2];
            springfield[0] = homer;
            springfield[1] = bart;

            foreach (Talkative h in springfield)
            {
                Console.WriteLine(h.Talk());
            }

    }
}
}
