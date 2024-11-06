using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt1
{
    abstract class SomeMatrix : IMatrix
    {
        private IVector[] matrix;
        public int ColumnsCount { get; private set; }
        public int RowsCount { get; private set; }

        public SomeMatrix(int rows, int cols) 
        {
            ColumnsCount = cols;
            RowsCount = rows;
        }

        protected void Construct(IVector[] memory)
        { 
            matrix = memory;
        }

        public int getValue(int row, int col)
        {
            return matrix[row].getElem(col);
        }

        public void setValue(int row, int col, int value)
        {
            matrix[row].setElem(value, col);
        }
    }
}
