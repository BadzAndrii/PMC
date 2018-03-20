using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace PMC
{
    class Program
    {
        private static void Main(string[] args)
        {
            new Point<int>(100);
            new Point2D<double>(12.3, 12.5);
            new Point3D<double>(15.5, 22.3, 55.5);
            new Position<Point<decimal>, decimal>();
            new Matrix<Position<Point<decimal>, decimal>, decimal>();
            new Container<Matrix<Position<Point<decimal>, decimal>, decimal>, decimal>();
            new Containers<Container<Matrix<Position<Point<decimal>, decimal>, decimal>, decimal>, decimal>();
        }

        #region hide_this
        public static Point<decimal> GetPoint(decimal X)
        {
           return new Point<decimal>(X);
        }
        public static Matrix<Position<Point2D<decimal>,decimal>,decimal> GetMatrix()
        {
            return null;
        }
        #endregion
    }
}