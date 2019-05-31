using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class HtmlPrinter : IPrinter
    {
        public void PrinterType()
        {
            Console.WriteLine($"Type --> { typeof(HtmlPrinter) }");
        }
    }
}
