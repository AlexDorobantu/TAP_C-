using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace bstree
{
    public class Comparaint : IComparer<int>
    {

        public int Compare(int arg0, int arg1)
        {
            if ((arg0 <= arg1))
            {
                return -1;
            }
            else
            {
                return 1;
            }

        }

    }
}
