using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportBase report = new ReportPDF("This is PDF doc", 5);
            IPrint<ReportBase> print = new Print<ReportBase>();
            print.PrintDoc(report, new HtmlPrinter());
            print.PrintDoc(report, new PanelPrinter());
            report = new ReportDOCX("This is DOCX doc", 10);
            print.PrintDoc(report, new ConsolePrinter());

        }
    }
}
