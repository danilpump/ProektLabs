using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMatrix
{
    abstract class SomeMatrix : IMatrix , IPrintable
    {
        private IVector[] matrix;
        public int ColumnsCount { get; private set; }
        public int RowsCount { get; private set; }

        public SomeMatrix(int rows, int cols) 
        {
            ColumnsCount = cols;
            RowsCount = rows;
        }

        protected void Construct(IVector[] memory)
        { 
            matrix = memory;
        }

        public int getValue(int row, int col)
        {
            return matrix[row].getElem(col);
        }

        public void setValue(int row, int col, int value)
        {
            matrix[row].setElem(value, col);
        }

        public virtual void Print(IPrinter printer, bool frame)
        {
            throw new NotImplementedException();
        }

        public virtual void DrawCell(int x, int y, int marginCoef, IPrinter printer)
        {
            int displacement = 1,
                _y = y * 2 + displacement,
                _x = x * (marginCoef + 1) + displacement;
            printer.DrawLine(_x, _y, _x + marginCoef + 1, _y);
            printer.DrawLine(_x + marginCoef + 1, _y, _x + marginCoef + 1, _y + 2);
            printer.DrawLine(_x, _y, _x, _y + 2);
            printer.DrawLine(_x, _y + 2, _x + marginCoef + 1, _y + 2);
            printer.DrawText(_x + 1, _y + 1, getValue(x, y).ToString());
        }

        public virtual void DrawFrame(int marginCoef, IPrinter printer)
        {
            int marginWidth = (marginCoef + 1) * ColumnsCount + 2,
                marginHeight = 2 * RowsCount + 2;
            printer.DrawLine(0, 0, marginWidth, 0);
            printer.DrawLine(marginWidth, 0, marginWidth, marginHeight);
            printer.DrawLine(0, 0, 0, marginHeight);
            printer.DrawLine(0, marginHeight, marginWidth, marginHeight);
        }
    }
}
