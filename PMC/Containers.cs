using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMC
{
    class Containers<TPoint, TNumeric> : Collection<Container<TPoint, TNumeric>> where TNumeric : struct { }

}
