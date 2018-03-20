using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC
{
    class Point<T> where T : struct
    {
        public T X { get; private set; }
        public Point(T x)
        {
            X = x;
        }
    }
}
