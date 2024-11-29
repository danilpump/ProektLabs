using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMatrix
{
    class HorizontalMatrixGroup : IPrintableMatrix
    {
        private List<IPrintableMatrix> matrixList;
        public HorizontalMatrixGroup()
        {
            matrixList = new List<IPrintableMatrix>();
        }
        public int RowsCount
        {
            get
            {
                int max = 0;
                foreach (var elem in matrixList) max = elem.RowsCount > max ? elem.RowsCount : max;
                return max;
            }
        }
        public int ColumnsCount {
            get
            {
                int sum = 0;
                foreach (var elem in matrixList) sum += elem.ColumnsCount;
                return sum;
            } 
        }
        private bool frame = false;
        public void Add(IPrintableMatrix elem) => matrixList.Add(elem);



        public int getValue(int row, int col)
        {
            int prevCols = 0;
            if (col > ColumnsCount) new NotImplementedException();
            int i = 0;
            for (; col >= matrixList[i].ColumnsCount; i++)
                col -= matrixList[i].ColumnsCount;
            if (row >= matrixList[i].RowsCount) return -1;
            return matrixList[i].getValue(row, col);
        }
        public void setValue(int row, int col, int value)
        {
            if (row > RowsCount || col > ColumnsCount) new NotImplementedException();
            int temp = 0;
            for (int i = 0; col > matrixList[i].ColumnsCount; i++)
            {
                temp = i;
                col -= matrixList[i].ColumnsCount;
            }
            matrixList[temp].setValue(row, col, value);
        }

        public void DrawCell(int row, int col, int marginCoef, int value, IPrinter printer, int offsetX = 0, int offsetY = 0)
        {
            if (row == 1 && col == 0)
                Console.WriteLine();
            if(value <= 0) return;
            int tempCol = col;
            //if (col >= ColumnsCount) throw new NotImplementedException();
            bool isCellAGroup = col >= matrixList.Count;
            int i = 0;
            int margin = 0;

            if (!isCellAGroup)
                for (; col >= matrixList[i].ColumnsCount; i++)
                    col -= matrixList[i].ColumnsCount;

            for (int k = 0; k < i; k++) 
                margin += calculateOffset(k);

            if (isCellAGroup)
                foreach (var el in matrixList)
                {
                    el.DrawCell(row, col, marginCoef, value, printer, margin + offsetX, offsetY);
                    return;
                }
            else
                matrixList[i].DrawCell(row, col, marginCoef, value, printer, margin + offsetX, offsetY);
            //matrixList[i].Print(printer, this.frame, offsetX + 1, offsetY + 1);
        }
        public void DrawFrame(int rows, int cols, int margin, IPrinter printer, int oX = 0, int oY = 0)
        {
            margin = 0;
            for (int i = 0; i < matrixList.Count; i++)
                margin = getMaxLenght(i) > margin ? getMaxLenght(i) : margin;
            /*for (int k = 0; k < matrixList.Count; k++)
            {
                margin += calculateOffset(k);
            }
            margin += 2;*/
            int marginWidth = (margin + 1) * cols + 2, // + 2 * matrixList.Count,//margin,
            marginHeight = 2 * rows + 2;
            printer.DrawLine(oX, oY, marginWidth + oX, oY);
            printer.DrawLine(marginWidth + oX, oY, marginWidth + oX, marginHeight + oY);
            printer.DrawLine(oX, oY, oX, marginHeight + oY);
            printer.DrawLine(oX, marginHeight + oY, marginWidth + oX, marginHeight + oY);
        }
        public void Print(IPrinter printer, bool frame, int offsetX = 0, int offsetY = 0)
        {
            //this.frame = frame;
            /*int matrixOffsetX = offsetX;
            for (int k = 0; k < matrixList.Count; k++)
                if (k != 0) // просуммировал отступы всех матриц
                    matrixOffsetX += calculateOffset(k - 1);*/

            if (frame) DrawFrame(RowsCount, ColumnsCount, 0, printer, offsetX, offsetY);
            for (int i = 0; i < /*matrixList.ElementAt(k).*/RowsCount; i++)
                for (int j = 0; j < /*matrixList.ElementAt(k).*/ColumnsCount; j++)
                    DrawCell(i, j, getMaxLenght(), getValue(i, j), printer, offsetX, offsetY);
            
            printer.Print();
        }
        private int calculateOffset(int k) 
        {
            if (k == -1) return 0;
            return matrixList.ElementAt(k).ColumnsCount * (getMaxLenght(/*k*/) + 1); //+ 2;
        }
        private int getMaxLenght(int k = -1) //если не указывается параметр, то ищется максимум для всех матриц в группе
        {
            int maxLenght = 0; // прошелся по одной матрице и определил отступы
            if (k==-1)
            {
                for(int r = 0; r < matrixList.Count; r++)
                    for (int i = 0; i < matrixList.ElementAt(r).RowsCount; i++)
                        for (int j = 0; j < matrixList.ElementAt(r).ColumnsCount; j++)
                            maxLenght = Math.Abs(matrixList.ElementAt(r).getValue(i, j)).ToString().Length > maxLenght ?
                                Math.Abs(matrixList.ElementAt(r).getValue(i, j)).ToString().Length 
                                : maxLenght;
            }
            else
            {
                for (int i = 0; i < matrixList.ElementAt(k).RowsCount; i++)
                    for (int j = 0; j < matrixList.ElementAt(k).ColumnsCount; j++)
                        maxLenght = Math.Abs(matrixList.ElementAt(k).getValue(i, j)).ToString().Length > maxLenght ?
                                Math.Abs(matrixList.ElementAt(k).getValue(i, j)).ToString().Length
                                : maxLenght;
            }
            return maxLenght;
        }
    }
}
