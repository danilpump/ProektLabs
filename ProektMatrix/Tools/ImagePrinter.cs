using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProektMatrix
{
    class ImagePrinter : IPrinter
    {
        private Bitmap bitmap;
        private Graphics graphics;
        private Pen pen = new Pen(Color.Black, 1);
        private int marginCoefVert = 20;
        private int marginCoefHor = 20;
        private PictureBox pictureBox;

        public ImagePrinter(Bitmap _bitmap, PictureBox _pictureBox)
        {
            this.bitmap = _bitmap;
            this.pictureBox = _pictureBox;
        }

        public void DrawLine(int _x, int _y, int _x1, int _y1)
        {
            int x = _x * marginCoefHor,
                y = _y * marginCoefVert,
                x1 = _x1 * marginCoefHor,
                y1 = _y1 * marginCoefVert;
            graphics = graphics is null ? Graphics.FromImage(bitmap) : graphics;
            graphics.DrawLine(pen, x, y, x1, y1);
        }

        public void DrawText(int x, int y, string text)
        {
            graphics.DrawString(text, new Font(FontFamily.GenericMonospace, 12, FontStyle.Regular),
                new SolidBrush(Color.Black),
                x * marginCoefHor, y * marginCoefVert);
        }

        public void Print()
        {
            pictureBox.Image = bitmap;
        }
    }
}
