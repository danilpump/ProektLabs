using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMatrix
{
    interface IPrinter
    {
        void DrawLine(int x, int y, int x1, int y1);
        void DrawText(int x, int y, string text);
        void Print();
    }
}
