using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public abstract class ReportBase
    {
        int _pages;
        string _text;
        public string GetText => _text;
        public int GetPages => _pages;
        public ReportBase(string text, int pages)
        {
            _text = text;
            _pages = pages;
        }
        public abstract void GoToFirstPage();
        public abstract void GoToLastPage();
        public abstract void GoToPage(int pageNumber);
    }
}
