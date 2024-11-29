using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMatrix
{
    class MatrixSparse : AMatrix
    {
        public MatrixSparse(int rows, int cols) : base(rows, cols)
        {
            Construct(allocMemory(rows, cols));
        }

        public override IVector[] allocMemory(int rows, int cols)
        {
            var matrix = new VectorSparse[rows];
            for (int i = 0; i < rows; i++)
                matrix[i] = new VectorSparse();
            return matrix;
        }
        public override void DrawCell(int r, int c, int marginCoef, int value, IPrinter printer, int offsetX = 0, int offsetY = 0)
        {
            if (value == 0) return;
            base.DrawCell(r, c, marginCoef, value, printer, offsetX, offsetY);
        }
    }
}
