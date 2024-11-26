using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMatrix
{
    abstract class ADecorator : IPrintableMatrix
    {
        //private IMatrix matrix;
        private IPrintableMatrix matrix;
        public int ColumnsCount { get; private set; }
        public int RowsCount { get; private set; }
        public ADecorator(IPrintableMatrix _matrix)
        {
            matrix = _matrix;
            ColumnsCount = _matrix.ColumnsCount;
            RowsCount = _matrix.RowsCount;
        }

        public virtual void Decorate() => Console.WriteLine("Decorate");
        public virtual void Restore() => Console.WriteLine("Restore");
        protected IPrintableMatrix getComponent()
        {
            return matrix;
        }
        public virtual int getValue(int row, int col) => matrix.getValue(row, col);
        public void setValue(int row, int col, int value) => matrix.setValue(row, col, value);
        public virtual void Print(IPrinter printer, bool frame)
        {
            int maxLenght = 0;
            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColumnsCount; j++)
                    maxLenght = getValue(i, j).ToString().Length > maxLenght ? getValue(i, j).ToString().Length : maxLenght;

            if (frame) DrawFrame(maxLenght, printer);
            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColumnsCount; j++)
                    DrawCell(i, j, maxLenght, getValue(i,j), printer);
            printer.Print();
        }
        public virtual void DrawCell(int r, int c, int marginCoef, int value, IPrinter printer)
        {
            matrix.DrawCell(r, c, marginCoef, getValue(r,c), printer);
        }
        public virtual void DrawFrame(int marginCoef, IPrinter printer)
        {
            matrix.DrawFrame(marginCoef, printer);
        }
    }
}
