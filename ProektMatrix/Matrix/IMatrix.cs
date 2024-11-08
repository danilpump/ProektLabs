using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMatrix
{
    interface IMatrix
    {
        int ColumnsCount { get; }
        int RowsCount { get; }
        int getValue(int row, int col);
        void setValue(int row, int col, int value);
    }
}
