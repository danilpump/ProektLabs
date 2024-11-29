using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMatrix
{
    class TransposeDecorator : ADecorator
    {
        public TransposeDecorator(IPrintableMatrix _matrix) : base(_matrix)
        {
        }
        public override int RowsCount => base.ColumnsCount;
        public override int ColumnsCount => base.RowsCount;
        public override int getValue(int row, int col) => base.getValue(col, row);

        /*public override void DrawCell(int r, int c, int marginCoef, int value, IPrinter printer, int offsetX = 0, int offsetY = 0)
        {
            base.DrawCell(c, r, marginCoef, value, printer, offsetX, offsetY);
        }
        public override void DrawFrame(int r, int c, int margin, IPrinter printer, int oX = 0, int oY = 0)
        {
            base.DrawFrame(c, r, margin, printer, oX, oY);
        }*/
        /*public override void Print(IPrinter printer, bool frame, int offsetX = 0, int offsetY = 0)
        {
            int maxLenght = 0;
            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColumnsCount; j++)
                    maxLenght = getValue(i, j).ToString().Length > maxLenght ? getValue(i, j).ToString().Length : maxLenght;

            if (frame) DrawFrame(ColumnsCount, RowsCount, maxLenght, printer, offsetX, offsetY);
            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColumnsCount; j++)
                    DrawCell(j, i, maxLenght, getValue(i, j), printer, offsetX, offsetY);
            printer.Print();
            //base.Print(printer, frame, offsetX, offsetY);
        }*/
    }
}
