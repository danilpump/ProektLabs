using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektCommandManager
{
    abstract class SomeMatrix : IMatrix, IPrintable
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

        public virtual int getValue(int row, int col)
        {
            return matrix[row].getElem(col);
        }

        public virtual void setValue(int row, int col, int value)
        {
            matrix[row].setElem(value, col);
        }

        public virtual void Print(IPrinter printer)
        {
            int maxLenght = 0;
            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColumnsCount; j++)
                    maxLenght = getValue(i, j).ToString().Length > maxLenght ? getValue(i, j).ToString().Length : maxLenght;

            DrawFrame(maxLenght, printer);
            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColumnsCount; j++)
                    DrawCell(i, j, maxLenght, printer);
            printer.Print();
        }

        public virtual void DrawCell(int x, int y, int marginCoef, IPrinter printer)
        {
            int _y = y * 2;
            int _x = x * (marginCoef + 1);
            printer.DrawLine(_x, _y, _x + marginCoef + 1, _y);
            printer.DrawLine(_x + marginCoef + 1, _y, _x + marginCoef + 1, _y + 2);
            printer.DrawLine(_x, _y, _x, _y + 2);
            printer.DrawLine(_x, _y + 2, _x + marginCoef + 1, _y + 2);
            printer.DrawText(_x + 1, _y + 1, getValue(x, y).ToString());
        }

        public virtual void DrawFrame(int marginCoef, IPrinter printer)
        {
            int marginWidth = (marginCoef + 1) * ColumnsCount;
            int marginHeight = 2 * RowsCount;
            printer.DrawLine(0, 0, marginWidth, 0);
            printer.DrawLine(marginWidth, 0, marginWidth, marginHeight);
            printer.DrawLine(0, 0, 0, marginHeight);
            printer.DrawLine(0, marginHeight, marginWidth, marginHeight);
        }
    }
}
