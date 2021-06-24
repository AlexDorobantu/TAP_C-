using System;

namespace ConsoleApp2
{
    class TAPMain
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(TapCourse.passCourse(false));
            }
            catch (TAPException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
