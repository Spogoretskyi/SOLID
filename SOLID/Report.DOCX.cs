using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class ReportDOCX : ReportBase
    {
        public ReportDOCX(string text, int pages)
            :base (text, pages)
        { }
        public override void GoToFirstPage()
        {
            Console.WriteLine("Frirst page of DOCX document");
        }
        public override void GoToLastPage()
        {
            Console.WriteLine("Last page of DOCX document");
        }

        public override void GoToPage(int pageNumber)
        {
            Console.WriteLine($"Page # {pageNumber} of DOCX document");
        }
    }
}
