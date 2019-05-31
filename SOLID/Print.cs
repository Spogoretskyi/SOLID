using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Print<T> : IPrint<T> where T: ReportBase
    {
        public void PrintDoc(T doc, IPrinter printType)
        {
            Console.WriteLine("-", 10);
            Console.WriteLine($"Type: {doc.GetType().Name}");
            Console.WriteLine($"Print on: {printType.GetType().Name}");
            Console.WriteLine($"Total amount of pages: {doc.GetPages}");
            Console.WriteLine($"Text: {doc.GetText}");
        }
    }
}
