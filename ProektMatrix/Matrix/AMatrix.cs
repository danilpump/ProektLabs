using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMatrix
{
    abstract class AMatrix : IPrintableMatrix//IMatrix , IPrintable
    {
        private IVector[] matrix;
        public int ColumnsCount { get; private set; }
        public int RowsCount { get; private set; }

        public AMatrix(int rows, int cols) 
        {
            ColumnsCount = cols;
            RowsCount = rows;
        }
        public abstract IVector[] allocMemory(int rows, int cols);

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

        public virtual void Print(IPrinter printer, bool frame, int offsetX = 0, int offsetY = 0)
        {
            int maxLenght = 0;
            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColumnsCount; j++)
                    maxLenght = Math.Abs(getValue(i, j)).ToString().Length > maxLenght ? Math.Abs(getValue(i, j)).ToString().Length : maxLenght;

            if (frame) DrawFrame(RowsCount, ColumnsCount, maxLenght, printer, offsetX, offsetY);
            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColumnsCount; j++)
                    DrawCell(i, j, maxLenght, getValue(i,j), printer, offsetX, offsetY);
            printer.Print();
        }

        public virtual void DrawCell(int r, int c, int marginCoef, int value, IPrinter printer, int offsetX = 0, int offsetY = 0)
        {
            int displacement = 1,
                _y = r * 2 + displacement + offsetY,
                _x = c * (marginCoef + 1) + displacement + offsetX;
            printer.DrawLine(_x, _y, _x + marginCoef + 1, _y);
            printer.DrawLine(_x + marginCoef + 1, _y, _x + marginCoef + 1, _y + 2);
            printer.DrawLine(_x, _y, _x, _y + 2);
            printer.DrawLine(_x, _y + 2, _x + marginCoef + 1, _y + 2);
            printer.DrawText(_x + 1, _y + 1, value.ToString());
        }

        public virtual void DrawFrame(int rows, int cols, int marginCoef, IPrinter printer, int oX = 0, int oY = 0)
        {
            int marginWidth = (marginCoef + 1) * cols + 2,
                marginHeight = 2 * rows + 2;
            printer.DrawLine(oX, oY, marginWidth + oX, oY);
            printer.DrawLine(marginWidth + oX, oY, marginWidth + oX, marginHeight + oY);
            printer.DrawLine(oX, oY, oX, marginHeight + oY);
            printer.DrawLine(oX, marginHeight + oY, marginWidth + oX, marginHeight + oY);
        }
    }
}
