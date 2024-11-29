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
        public virtual int ColumnsCount { get { return matrix.ColumnsCount; } }
        public virtual int RowsCount { get { return matrix.RowsCount; } }
        public ADecorator(IPrintableMatrix _matrix)
        {
            matrix = _matrix;
            /*ColumnsCount = _matrix.ColumnsCount;
            RowsCount = _matrix.RowsCount;*/
        }

        public virtual void Decorate() => Console.WriteLine("Decorate");
        public virtual void Restore() => Console.WriteLine("Restore");
        
        public virtual int getValue(int row, int col) => matrix.getValue(row, col);
        public void setValue(int row, int col, int value) => matrix.setValue(row, col, value);
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
            matrix.DrawCell(r, c, marginCoef, value, printer, offsetX, offsetY);
        }
        public virtual void DrawFrame(int rows, int cols, int marginCoef, IPrinter printer, int offsetX = 0, int offsetY = 0)
        {
            matrix.DrawFrame(rows, cols, marginCoef, printer, offsetX, offsetY);
        }
        public IPrintableMatrix getComponent() 
        {
            return matrix;
        }
    }
}
