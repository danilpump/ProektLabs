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

        private bool frame = false;
        private SomeMatrix matrix;
        private RenumDecorator decorator;

        private void Print()
        {
            matrix.Print(new ConsolePrinter(), frame);
            matrix.Print(new ImagePrinter(pictureBox1), frame);
        }
        private void Init(SomeMatrix _matrix, int n, int m)
        {
            MatrixInit.Init(_matrix, n, m);
            matrix = _matrix;
            Print();
            decorator = null;
        }

        private void button1_Click(object sender, EventArgs e) // Default
        {
            Init(new MatrixDefault(5, 5), 25, 15);
        }

        private void button2_Click(object sender, EventArgs e) // Sparse
        {
            Init(new MatrixSparse(5, 5), 10, 10);
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
                decorator.Renumerate();
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
    }
}
