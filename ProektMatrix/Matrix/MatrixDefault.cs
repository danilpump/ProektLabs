using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMatrix
{
    class MatrixDefault : SomeMatrix, IPrintable
    {
        public MatrixDefault(int rows, int cols) : base(rows, cols)
        {
            Construct(allocMemory(rows, cols));
        }

        public override IVector[] allocMemory(int rows, int cols)
        {
            var matrix = new VectorDefault[rows];
            for (int i = 0; i < rows; i++)
                matrix[i] = new VectorDefault(cols);
            return matrix;
        }

        public override void Print(IPrinter printer, bool frame)
        {
            int maxLenght = 0;
            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColumnsCount; j++)
                    maxLenght = getValue(i, j).ToString().Length > maxLenght ? getValue(i, j).ToString().Length : maxLenght;

            if (frame) DrawFrame(maxLenght, printer);
            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColumnsCount; j++)
                    DrawCell(i, j, maxLenght, printer);
            printer.Print();
        }
    }
}
