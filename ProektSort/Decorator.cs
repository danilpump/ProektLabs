using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektSort
{
    class Decorator : IComparer
    {
        protected IComparer comparer;
        public Decorator(IComparer comparer)
        {
            this.comparer = comparer;
        }

        public virtual bool Compare(int x, int y)
        {
            return comparer.Compare(x,y);
        }
    }
}
