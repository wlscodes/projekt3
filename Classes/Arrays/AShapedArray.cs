﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Classes.Arrays
{
    public sealed class AShapedArray : ArrayBase
    {
        public AShapedArray()
        {
            Name = "AShapedArray";
        }
        public override int[] CreateArray(int size)
        {
            int[] arr = new int[size];
            int center = (int)size / 2;
            for (int i = 0; i < center; i++)
            {
                arr[i] = i * 2 + 2;
            }
            for (int i = center; i < size; i++)
            {
                arr[i] = (size - i) * 2 - 1;
            }
            return arr;
        }
    }
}
