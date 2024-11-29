using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProektCommandManager
{
    class MatrixInit
    {
        static Random rand = new Random();
        public static void Init(IMatrix matrix, int notnull, int max)
        {
            while (notnull>0)
            {
                for (int i = 0; i < matrix.RowsCount; i++)
                {
                    for (int j = 0; j < matrix.ColumnsCount; j++)
                    {
                        if (notnull == 0) break;
                        
                        if(rand.NextDouble() < 0.4)
                        {
                            int randVal = rand.Next(max);
                            if (randVal != 0 && matrix.getValue(i, j) == 0)
                            {
                                notnull--;
                                matrix.setValue(i, j, randVal);
                            }
                        }
                    }
                }
            }
        }
    }
}
