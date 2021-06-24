using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class TapCourse
    {

        public static string passCourse(bool hasStudied)
        {
            if (hasStudied)
            {
                return "You pass the course";
            }
            else
            {
                throw new TAPException("You failed, better study next time");
            }

        }
    }
}
