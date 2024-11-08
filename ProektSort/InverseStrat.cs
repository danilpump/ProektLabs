using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektSort
{
    class InverseStrat : Decorator
    {
        public InverseStrat(IComparer comparer) : base(comparer) { }

        public override bool Compare(int x, int y)
        {
            return !base.Compare(x, y);
        }
    }
}
