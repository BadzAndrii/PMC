using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC
{
    class Container<TPoint, TNumeric> : Collection<Matrix<TPoint, TNumeric>> where TNumeric : struct { }

}
