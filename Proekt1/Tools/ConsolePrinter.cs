using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt1.Tools
{
    class ConsolePrinter : IPrinter
    {
        private StringBuilder[] sb = new StringBuilder[1];
        public void DrawLine(int x, int y, int x1, int y1)
        {
            Resize(x1, y1);
            bool horizontal = x < x1;

            if (horizontal)
            {
                for (int i = x; i <= x1; i++)
                {
                    if (i == x || i == x1)
                    {
                        sb[y][i] = '┼';
                        continue;
                    }
                    sb[y][i] = '─';
                }
            } 
            else
            {
                for (int i = y; i <= y1; i++)
                {
                    Resize(x1, i);
                    if(i == y || i == y1)
                    {
                        sb[i][x] = '┼';
                        continue;
                    }
                    sb[i][x] = '│';
                }
            }
        }

        public void DrawText(int x, int y, string text)
        {
            Resize(x + text.Length, y);
            for (int i = x, j = 0; i < x + text.Length; i++, j++)
                sb[y][i] = text.ElementAt(j);
        }

        public void Print()
        {
            foreach (StringBuilder item in sb) 
                Console.WriteLine(item.ToString());
        }

        private void Resize(int x, int y) 
        {
            if (y >= sb.Length)
                while (y >= sb.Length) 
                {
                    List<StringBuilder> list = sb.ToList<StringBuilder>();
                    list.Add(new StringBuilder(""));
                    sb = list.ToArray();
                }
            else if (sb[y] is null || x >= sb[y].Length)
            {
                if (sb[y] is null) sb[y] = new StringBuilder("");
                while (x >= sb[y].Length) sb[y].Append(' ');
            }
        }
    }
}
