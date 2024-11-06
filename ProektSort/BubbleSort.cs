using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektSort
{
    internal class BubbleSort : ASorter
    {
        public override void Sort(int[] array, IComparer comparer)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (comparer.Compare(array[j], array[j + 1]))
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
