using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt1
{
    class MatrixStatistic
    {
        public int Sum { get; private set; } = 0;
        public double Avg { get; private set; }
        public int Max { get; private set; } = int.MinValue;
        public int Notnull { get; private set; } = 0;

        public MatrixStatistic(IMatrix matrix) 
        {
            for (int i = 0; i < matrix.RowsCount; i++)
                for (int j = 0; j < matrix.ColumnsCount; j++)
                {
                    int el = matrix.getValue(i, j);
                    Sum += el;

                    if (el > Max) Max = el;
                    if (el != 0) Notnull++;
                }
            Avg = (double)Sum / (matrix.ColumnsCount * matrix.RowsCount);
        }
    }
}
