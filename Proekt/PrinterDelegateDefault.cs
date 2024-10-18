using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt
{
    class PrinterDelegateDefault : IPrinterDelegate
    {
        public virtual void print(IPrintable text)
        {
            text.Print(this);
        }

        public void print(string text)
        {
            Console.Write(text);
        }
    }
}
