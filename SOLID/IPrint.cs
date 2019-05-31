using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    interface IPrint<T> where T: class
    {
        void PrintDoc(T doc, IPrinter printType);
    }
}
