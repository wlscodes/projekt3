using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Classes.Arrays
{
    public sealed class DescendingArray : ArrayBase
    {
        public DescendingArray()
        {
            Name = "Descending Array";
        }
        public override int[] CreateArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = size - i;
            }
            return arr;
        }
    }
}
