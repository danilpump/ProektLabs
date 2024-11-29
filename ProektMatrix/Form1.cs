using ProektMatrix.Decorator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProektMatrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool frame = true;
        private IPrintableMatrix matrix;
        private RenumDecorator decorator;
        private HorizontalMatrixGroup matrixGroup = new HorizontalMatrixGroup();
        private HorizontalMatrixGroup matrixGroup2 = new HorizontalMatrixGroup();
        private bool flag1 = true;

        private void Print()
        {
            matrix.Print(new ConsolePrinter(), frame);
            if (flag1) 
            {
                pictureBox1.Image = null; 
                pictureBox3.Image = null;
            }
            if (flag1)
                matrix.Print(new ImagePrinter(pictureBox1), frame);
            else
                matrix.Print(new ImagePrinter(pictureBox3), frame);
            flag1 = !flag1;
        }
        private void Init(IPrintableMatrix _matrix, int n, int m)
        {
            MatrixInit.Init(_matrix, n, m);
            matrix = _matrix;
            matrixGroup.Add(_matrix);
            Print();
            decorator = null;
        }

        private void button1_Click(object sender, EventArgs e) // Default
        {
            int r = (int)numericUpDown1.Value;
            int c = (int)numericUpDown2.Value;
            Init(new MatrixDefault(r, c), r*c, 10);
        }

        private void button2_Click(object sender, EventArgs e) // Sparse
        {
            int r = (int)numericUpDown1.Value;
            int c = (int)numericUpDown2.Value;
            Init(new MatrixSparse(r, c), r * c / 2, 10);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            frame = !frame;
        }

        private void button3_Click(object sender, EventArgs e) // Renumerate
        {
            if (matrix != null)
            {
                if (decorator is null) decorator = new RenumDecorator(matrix);
                decorator.Decorate();
                matrix = decorator;
                Print();
            }
        }

        private void button4_Click(object sender, EventArgs e) // Restore
        {
            if (matrix != null && decorator != null)
            {
                decorator.Restore();
                matrix = decorator;
                Print();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*if (matrixGroup is null) */
            /*matrixGroup = new HorizontalMatrixGroup();
            MatrixSparse ms = new MatrixSparse(3, 3);
            MatrixDefault md = new MatrixDefault(3, 3);
            MatrixInit.Init(ms, 4, 10);
            MatrixInit.Init(md, 9, 15);
            matrixGroup.Add(ms);
            matrixGroup.Add(md);*/

            PrintGroup(matrixGroup);
            decorator = null;
        }
        private void PrintGroup(IPrintableMatrix matrixGr)
        {
            matrixGr.Print(new ConsolePrinter(), frame);
            matrixGr.Print(new ImagePrinter(pictureBox2), frame);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            matrixGroup = new HorizontalMatrixGroup();
            pictureBox2.Image = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TransposeDecorator tr = new TransposeDecorator(matrixGroup);
            pictureBox2.Image = null;
            tr.Print(new ConsolePrinter(), frame);
            tr.Print(new ImagePrinter(pictureBox2), frame);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MatrixDefault md = new MatrixDefault(2, 2);
            MatrixInit.Init(md, 4, 10);
            matrixGroup2.Add(md);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MatrixDefault md = new MatrixDefault(3, 3);
            MatrixInit.Init(md, 9, 10);
            matrixGroup2.Add(md);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //matrixGroup2 = new HorizontalMatrixGroup();
            matrixGroup2.Add(matrixGroup);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            matrixGroup2 = new HorizontalMatrixGroup();
            pictureBox2.Image = null;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PrintGroup(matrixGroup2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            /*Init(new MatrixDefault(1, 1), 1, 10);
            Init(new MatrixDefault(2, 2), 4, 10);
            Init(new MatrixDefault(1, 2), 2, 10);
            TransposeDecorator tr = new TransposeDecorator(matrixGroup);
            matrixGroup2.Add(tr);
            matrixGroup = new HorizontalMatrixGroup();

            Init(new MatrixDefault(2, 1), 2, 10);
            Init(new MatrixDefault(2, 2), 4, 10);
            tr = new TransposeDecorator(matrixGroup);
            matrixGroup2.Add(tr);

            MatrixDefault md = new MatrixDefault(1, 1);
            MatrixInit.Init(md, 1, 10);

            matrixGroup2.Add(md);*/

            /*Init(new MatrixDefault(1, 1), 1, 10);
            Init(new MatrixDefault(1, 1), 1, 10);
            TransposeDecorator tr = new TransposeDecorator(matrixGroup);
            matrixGroup2.Add(tr);
            matrixGroup = new HorizontalMatrixGroup();*/

            /*MatrixDefault md = new MatrixDefault(1, 1);
            MatrixInit.Init(md, 1, 10);

            matrixGroup2.Add(md);*/

            TransposeDecorator tr = new TransposeDecorator(matrixGroup2);
            pictureBox2.Image = null;
            tr.Print(new ConsolePrinter(), frame);
            tr.Print(new ImagePrinter(pictureBox2), frame);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Init(new MatrixDefault(2, 2), 4, 10);
            Init(new MatrixDefault(4, 3), 12, 10);
            Init(new MatrixDefault(1, 3), 3, 10);
            TransposeDecorator tr = new TransposeDecorator(matrixGroup);
            matrixGroup2.Add(tr);
            matrixGroup = new HorizontalMatrixGroup();

            Init(new MatrixDefault(2, 4), 8, 10);
            Init(new MatrixDefault(2, 3), 6, 10);
            tr = new TransposeDecorator(matrixGroup);
            matrixGroup2.Add(tr);

            MatrixDefault md = new MatrixDefault(1, 1);
            MatrixInit.Init(md, 1, 10);

            matrixGroup2.Add(md);

            tr = new TransposeDecorator(matrixGroup2);
            pictureBox2.Image = null;
            tr.Print(new ConsolePrinter(), frame);
            tr.Print(new ImagePrinter(pictureBox2), frame);
        }
    }
}
