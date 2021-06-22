using System;
using System.Collections.Generic;
using System.Text;

namespace filesystem2
{
    public class Order : IComparer<AComponent>
    {
        public int Compare(AComponent arg0, AComponent arg1)
        {
            //  TODO Auto-generated method stub
            return arg0.GetName().CompareTo(arg1.GetName());
        }
    }
}
