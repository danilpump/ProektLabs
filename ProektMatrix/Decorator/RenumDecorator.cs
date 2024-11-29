using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMatrix.Decorator
{
    class RenumDecorator : ADecorator
    {
        private int[] Rows;
        private int[] Columns;
        public RenumDecorator(IPrintableMatrix _matrix) : base(_matrix)
        {
            Init(_matrix.RowsCount, _matrix.ColumnsCount);
        }
        private void Init(int rows, int cols)
        {
            Rows = new int[rows];
            Columns = new int[cols];
            for (int i = 0; i < rows; i++) Rows[i] = i;
            for (int i = 0; i < cols; i++) Columns[i] = i;
        }
        public override void Decorate()
        {
            Random rand = new Random();       
            int flag = rand.Next(2);
            int rand1, rand2 = 0, size;
            size = flag == 1 ? ColumnsCount : RowsCount;
            rand1 = rand.Next(size);
            while (rand1 == rand2)
                rand2 = rand.Next(size);
            if (flag == 1) Swap(ref Columns[rand1], ref Columns[rand2]);
            else Swap(ref Rows[rand1], ref Rows[rand2]);

        }
        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public override int getValue(int row, int col) => base.getValue(Rows[row], Columns[col]);        
        public void Restore() 
        {
            Init(RowsCount, ColumnsCount);
        }
        
    }
}
