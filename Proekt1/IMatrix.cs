using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt1
{
    interface IMatrix
    {
        int ColumnsCount { get; }
        int RowsCount { get; }
        int getValue(int row, int col);
        void setValue(int row, int col, int value);
    }
}
