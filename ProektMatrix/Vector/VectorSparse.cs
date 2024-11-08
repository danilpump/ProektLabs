using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMatrix
{
    class VectorSparse : IVector
    {
        Dictionary<int, int> vec;
        public int Length => vec.Count;

        public VectorSparse()
        {
            vec = new Dictionary<int, int>();
        }

        public int getElem(int index)
        {
            if (index >= 0)
                return vec.FirstOrDefault(el => el.Key == index).Value;
            else
                throw new Exception("Uncorrect index");

        }

        public void setElem(int value, int index = -1)
        {
            if (index == -1)
                vec.Add(Length+1, value);
            else if (index >= 0)
                vec.Add(index, value);
            else
                throw new Exception("Uncorrect index");
        }
    }
}
