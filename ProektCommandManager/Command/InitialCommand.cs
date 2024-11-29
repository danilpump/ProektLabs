using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektCommandManager
{
    class InitialCommand : ACommand
    {
        private IMatrix matrix;

        public InitialCommand(IMatrix matrix)
        {
            this.matrix = matrix;
        }
        public override void doOperation()
        {
            for (int i = 0; i < matrix.RowsCount; i++)
                for (int j = 0; j < matrix.ColumnsCount; j++)
                    matrix.setValue(i, j, 0);
        }
    }
}
