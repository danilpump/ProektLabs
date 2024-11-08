using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektSort
{
    abstract class ASorter // Component
    {
        public abstract void Sort(int[] array, IComparer comparer);
    }
}
