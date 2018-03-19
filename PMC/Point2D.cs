using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC
{
    class Point2D<T> : Point<T>
    {
        public T myY { get; private set; }

        public Point2D(T x,T y) : base(x)
        {
            myY = y;
        }
    }
}
