using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektSort
{
    internal class AscendingStrat : IComparer
    {
        public bool Compare(int x, int y)
        {
            return x > y;
        }
    }
}
