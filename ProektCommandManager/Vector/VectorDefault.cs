using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektCommandManager
{
    class VectorDefault : IVector
    {
        int[] vec;
        public int Length => vec.Length;

        public VectorDefault(int size) 
        {
            vec = new int[size];
        }

        public int getElem(int index)
        {
            if (index >= 0)
                return vec[index];
            else
                throw new Exception("Uncorrect index");
        }

        public void setElem(int value, int index = -1)
        {
            if (index == -1)
                vec.Append(value);
            else if (index >= 0)
                vec[index] = value;
            else
                throw new Exception("Uncorrect index");
        }
    }
}
