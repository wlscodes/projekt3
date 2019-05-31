using Project3.Classes.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Classes.Arrays
{
    public sealed class SelectionSort : SortingBase
    {
        public SelectionSort()
        {
            Name = "Selection Sort";
        }
        public override void Sort(int[] arr)
        {
            int k;
            for (int i = 0; i < (arr.Length - 1); i++)
            {
                int tmp = arr[i];
                k = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < tmp)
                    {
                        k = j;
                        tmp = arr[j];
                    }

                arr[k] = arr[i];
                arr[i] = tmp;
            }
        }
    }
}
