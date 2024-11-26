﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMatrix
{
    interface IPrintable
    {
        void Print(IPrinter printer, bool frame);
        void DrawFrame(int marginCoef, IPrinter printer);
        void DrawCell(int x, int y, int marginCoef, int value, IPrinter printer);
    }
}
