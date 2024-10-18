using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt
{
    class PrinterDefault : IPrinter
    {
        public virtual void print(string text)
        {
            Console.Write(text);
        }
    }
}
