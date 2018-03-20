using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC
{
    class Matrix<TPoint, TNumeric> : Collection<Position<TPoint, TNumeric>> where TNumeric : struct { }

}
