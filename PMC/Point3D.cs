using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC
{
    class Point3D<T> : Point2D<T>
    {
        public T myZ { get; private set; }

        public Point3D(T x,T y,T z):base(x,y)
        {
            myZ = z;
        }
    }
}
