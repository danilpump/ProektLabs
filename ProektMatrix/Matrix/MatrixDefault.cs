using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMatrix
{
    class MatrixDefault : AMatrix
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
    }
}
