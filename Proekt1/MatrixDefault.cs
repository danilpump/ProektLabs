using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt1
{
    class MatrixDefault : SomeMatrix
    {
        public MatrixDefault(int rows, int cols) : base(rows, cols)
        {
            matrix = new VectorDefault[rows];
            for (int i = 0; i < rows; i++)
                matrix[i] = new VectorDefault(cols);
        }

    }
}
