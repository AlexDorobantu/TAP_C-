using System;
using System.Collections.Generic;
using System.Text;

namespace iterator
{
    /**
 * http://www.tutorialspoint.com/design_pattern/iterator_pattern.htm
 */
    public interface Iterator
    {
        public bool HasNext();
        public Object Next();
    }
}
