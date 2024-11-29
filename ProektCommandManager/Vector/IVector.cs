using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektCommandManager
{
    interface IVector
    {
        int Length { get; }

        int getElem(int index);
        void setElem(int value, int index = -1);
    }
}
