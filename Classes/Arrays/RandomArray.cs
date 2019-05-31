using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Classes.Arrays
{
    public sealed class RandomArray : ArrayBase
    {
        public RandomArray()
        {
            Name = "Random Array";
        }
        public override int[] CreateArray(int size)
        {
            int[] arr = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(1, size + 1);
            }
            return arr;
        }
    }
}
