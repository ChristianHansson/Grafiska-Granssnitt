using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_Grafiska_Gränssnitt_v1
{
    public interface IObserver
    {
        void update(IObservable io, string arg);
    }
}
