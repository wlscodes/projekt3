using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Classes.Arrays
{
    public sealed class AscendingArray : ArrayBase
    {
        public AscendingArray()
        {
            Name = "Ascending Array";
        }

        public override int[] CreateArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = i + 1;
            }
            return arr;
        }
    }
}
