using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC
{
    class Point<T>
    {
        public T myX { get; private set; }
        public Point(T x)
        {
            myX = x;
        }
    }
}
