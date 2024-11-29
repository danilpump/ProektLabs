using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektCommandManager
{
    interface IPrintable
    {
        void Print(IPrinter printer);
        void DrawFrame(int marginCoef, IPrinter printer);
        void DrawCell(int x, int y, int marginCoef, IPrinter printer);
    }
}
