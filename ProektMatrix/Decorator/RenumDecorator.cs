using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMatrix.Decorator
{
    class RenumDecorator : SomeMatrix
    {
        private SomeMatrix decoratedMatrix;
        public RenumDecorator(SomeMatrix _matrix) : base(_matrix.RowsCount, _matrix.ColumnsCount)
        {
            decoratedMatrix = _matrix;
            Construct(allocMemory(_matrix.RowsCount, _matrix.ColumnsCount));
            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColumnsCount; j++)
                    setValue(i, j, _matrix.getValue(i, j));
        }

        public override IVector[] allocMemory(int rows, int cols)
        {
            return decoratedMatrix is null ? null : decoratedMatrix.allocMemory(rows, cols);
        }
        public void Renumerate()
        {
            Random rand = new Random();
            int[] temp1, temp2;
            int rand1 = rand.Next(10), rand2, size;
            size = rand1 > 5 ? ColumnsCount : RowsCount;
            temp1 = new int[size];
            temp2 = new int[size];
            rand1 = rand.Next(size);
            rand2 = rand.Next(size);
            if (rand1 > 5)
            {
                for (int i = rand1, j = rand2, k = 0; k < size; k++)
                {
                    temp1[k] = decoratedMatrix.getValue(i, k);
                    temp2[k] = decoratedMatrix.getValue(j, k);
                }
                for (int i = rand1, j = rand2, k = 0; k < size; k++)
                {
                    decoratedMatrix.setValue(i, k, temp2[k]);
                    decoratedMatrix.setValue(j, k, temp1[k]);
                }
            }
            else
            {
                for (int i = rand1, j = rand2, k = 0; k < size; k++)
                {
                    temp1[k] = decoratedMatrix.getValue(k, i);
                    temp2[k] = decoratedMatrix.getValue(k, j);
                }
                for (int i = rand1, j = rand2, k = 0; k < size; k++)
                {
                    decoratedMatrix.setValue(k, i, temp2[k]);
                    decoratedMatrix.setValue(k, j, temp1[k]);
                }
            }
        }
        public void Restore() 
        {
            for (int i = 0; i < RowsCount;i++)
                for(int j = 0; j < ColumnsCount;j++)
                    decoratedMatrix.setValue(i,j, getValue(i, j));
        }
        public override void Print(IPrinter printer, bool frame)
        {
            decoratedMatrix.Print(printer, frame);
        }
    }
}
