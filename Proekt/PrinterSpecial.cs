using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proekt
{
    class PrinterSpecial : PrinterDefault
    {
        public override void print(string text)
        {
            if (text.Length > 1)
                base.print("(" + text + ")");
            else base.print(text);
        }
    }
}
