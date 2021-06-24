using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
