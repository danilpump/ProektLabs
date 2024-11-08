using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProektMatrix
{
    public partial class Form1 : Form
    {
        private bool frame = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Default
        {
            MatrixDefault md = new MatrixDefault(5, 5);
            MatrixInit.Init(md, 25, 10);
            Console.WriteLine("DefaultMatrix:");
            md.Print(new ConsolePrinter(), frame);

            md.Print(new ImagePrinter(new Bitmap(2000, 2000), pictureBox1), frame);
        }

        private void button2_Click(object sender, EventArgs e) // Sparse
        {
            MatrixSparse ms = new MatrixSparse(5, 5);
            MatrixInit.Init(ms, 12, 10);
            Console.WriteLine("DefaultMatrix:");
            ms.Print(new ConsolePrinter(), frame);

            ms.Print(new ImagePrinter(new Bitmap(2000, 2000), pictureBox1), frame);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            frame = !frame;
        }
    }
}
