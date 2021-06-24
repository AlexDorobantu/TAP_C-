using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TAPMain
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
