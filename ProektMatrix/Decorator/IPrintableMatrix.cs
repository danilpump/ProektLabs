using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMatrix
{
    interface IPrintableMatrix : IMatrix, IPrintable
    {
        int ColumnsCount { get; }
        int RowsCount { get; }
        int getValue(int row, int col);
        void setValue(int row, int col, int value);
        void Print(IPrinter printer, bool frame, int offsetX = 0, int offsetY = 0);
        void DrawFrame(int rows, int cols, int marginCoef, IPrinter printer, int offsetX = 0, int offsetY = 0);
        void DrawCell(int x, int y, int marginCoef, int value, IPrinter printer, int offsetX = 0, int offsetY = 0);
    }
}
