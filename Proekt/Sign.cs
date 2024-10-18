using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt
{
    class Sign : IPrintable
    {
        private char sign;

        public Sign(char _sign)
        {
            sign = _sign;
        }

        public void Print(IPrinter printer)
        {
            printer.print(sign.ToString());
        }
    }
}
