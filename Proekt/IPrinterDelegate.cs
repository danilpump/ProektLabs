using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt
{
    interface IPrinterDelegate : IPrinter
    {
        void print(IPrintable text);
    }
}
