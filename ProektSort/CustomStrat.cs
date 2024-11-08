using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektSort
{
    internal class CustomStrat : Decorator
    {
        public CustomStrat(IComparer comparer) : base(comparer) { }

        public override bool Compare(int x, int y)
        {
            if (x % 2 == 0 && y % 2 == 0)
                return comparer.Compare(x, y);
            else if (x % 2 != 0 && y % 2 != 0)
                return !comparer.Compare(x, y);
            else if (x % 2 != 0)
                return false;
            else if (y % 2 != 0)
                return true;
            return false;
        }
    }
}
