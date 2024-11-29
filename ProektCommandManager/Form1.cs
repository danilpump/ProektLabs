using System.Drawing.Drawing2D;

namespace ProektCommandManager
{
    public partial class Form1 : Form
    {
        private MatrixDefault matrix;
        public Form1()
        {
            InitializeComponent();
            matrix = new MatrixDefault(2, 2);
            ICommand init = new InitialCommand(matrix);
            init.Execute();

            matrix.Print(new ImagePrinter(pictureBox1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            if (matrix != null)
            {
                Random random = new Random();
                int row = random.Next(matrix.RowsCount),
                    col = random.Next(matrix.ColumnsCount),
                    value = random.Next(10);

                ICommand addCommand = new AddToMatrix(matrix, row, col, value);
                addCommand.Execute();

                matrix.Print(new ImagePrinter(pictureBox1));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            CommandManager.getInstance().Undo();
            matrix.Print(new ImagePrinter(pictureBox1));
        }
    }
}
