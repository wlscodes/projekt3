using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Classes.Sorting
{
    public sealed class InsertionSort : SortingBase
    {
        public InsertionSort()
        {
            Name = "Insertion Sort";
        }
        public override void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                int tmp = arr[j];

                while ((j > 0) && (arr[j - 1] > tmp))
                {
                    arr[j] = arr[j - 1];
                    j--;
                }

                arr[j] = tmp;
            }
        }
    }
}
