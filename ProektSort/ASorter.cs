using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektSort
{
    internal abstract class ASorter
    {
        public abstract void Sort(int[] array, IComparer comparer);
    }
}
