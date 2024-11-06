using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektSort
{
    internal interface IComparer
    {
        public bool Compare(int x, int y);
    }
}
