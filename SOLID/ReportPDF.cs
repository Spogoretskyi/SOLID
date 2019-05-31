using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class ReportPDF : ReportBase
    {
        public ReportPDF(string text, int pages)
            :base (text, pages)
        { }
        public override void GoToFirstPage()
        {
            Console.WriteLine("Frirst page of PDF document");
        }

        public override void GoToLastPage()
        {
            Console.WriteLine("Last page of PDF document");
        }

        public override void GoToPage(int pageNumber)
        {
            Console.WriteLine($"Page # {pageNumber} of PDF document");
        }
    }
}
