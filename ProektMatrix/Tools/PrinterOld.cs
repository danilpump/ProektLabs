using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMatrix
{
    class PrinterOld
    {
        public static void Print(IMatrix matrix) 
        {
            for (int i = 0; i < matrix.RowsCount; i++)
            {
                for (int j = 0; j < matrix.ColumnsCount; j++)
                {
                    Console.Write("{0, 3} ", matrix.getValue(i, j));
                }
                Console.WriteLine();
            }
        }
    }
}
