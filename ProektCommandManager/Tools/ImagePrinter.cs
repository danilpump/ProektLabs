using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProektCommandManager
{
    class ImagePrinter : IPrinter
    {
        private Bitmap bitmap;
        private Graphics graphics;
        private Pen pen;
        private Font font;
        private Brush brush;
        private int marginCoefVert = 20;
        private int marginCoefHor = 20;
        private PictureBox pictureBox;

        public ImagePrinter(PictureBox _pictureBox)
        {
            pictureBox = _pictureBox;
            bitmap = new Bitmap(2000, 2000);
            pen = new Pen(Color.Black, 1);
            font = new Font(FontFamily.GenericMonospace, 12, FontStyle.Regular);
            brush = new SolidBrush(Color.Black);
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
            graphics.DrawString(text, font, brush, x * marginCoefHor, y * marginCoefVert);            
        }
        public void Print() => pictureBox.Image = bitmap;
    }
}
