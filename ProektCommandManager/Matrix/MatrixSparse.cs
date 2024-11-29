using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektCommandManager
{
    class MatrixSparse : SomeMatrix
    {
        public MatrixSparse(int rows, int cols) : base(rows, cols)
        {
            var matrix = new VectorSparse[rows];
            for (int i = 0; i < rows; i++)
                matrix[i] = new VectorSparse();
            Construct(matrix);
        }
        public override void DrawCell(int x, int y, int marginCoef, IPrinter printer)
        {
            base.DrawCell(x, y, marginCoef, printer);
        }
    }
}
