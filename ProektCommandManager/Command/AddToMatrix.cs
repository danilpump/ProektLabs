using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektCommandManager
{
    class AddToMatrix : ACommand
    {
        private readonly IMatrix matrix;
        private readonly int row;
        private readonly int col;
        private readonly int value;

        public AddToMatrix(IMatrix matrix, int row, int col, int value)
        {
            this.matrix = matrix;
            this.row = row;
            this.col = col;
            this.value = value;
        }

        public override void doOperation()
        {
            matrix.setValue(row, col, value);
        }
    }
}
