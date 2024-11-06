using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt1
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
    }
}
