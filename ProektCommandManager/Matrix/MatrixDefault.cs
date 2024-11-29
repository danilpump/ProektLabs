using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektCommandManager
{
    class MatrixDefault : SomeMatrix
    {
        public MatrixDefault(int rows, int cols) : base(rows, cols)
        {
            var matrix = new VectorDefault[rows];
            for (int i = 0; i < rows; i++)
                matrix[i] = new VectorDefault(cols);
            Construct(matrix);
        }
    }
}
