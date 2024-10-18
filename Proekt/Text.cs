using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt
{
    class Text : IPrintable
    {
        private List<IPrintable> text;

        public Text(IPrintable[] _str)
        {
            text = new List<IPrintable>();
            foreach (var el in _str)
                text.Add(el);
        }

        public void Print(IPrinter printer)
        {
            foreach (var el in text)
                el.Print(printer);
        }
    }
}
