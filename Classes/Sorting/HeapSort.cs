using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Classes.Sorting
{
    public sealed class HeapSort : SortingBase
    {
        public HeapSort()
        {
            Name = "Heap Sort";
        }
        private void Heapify(int[] t, int left, int right)
        {
            int i = left, j = 2 * i + 1;
            int buf = t[i];

            while (j <= right)
            {
                if (j < right)
                    if (t[j] < t[j + 1])
                        j++;
                if (buf >= t[j]) break;

                t[i] = t[j];
                i = j;
                j = 2 * i + 1;
            }

            t[i] = buf;
        }

        public override void Sort(int[] arr)
        {
            int left = (int)arr.Length / 2;
            int right = (int)arr.Length - 1;
            while (left > 0)
            {
                left--;
                Heapify(arr, left, right);
            }

            while (right > 0)
            {
                int buf = arr[left];
                arr[left] = arr[right];
                arr[right] = buf;
                right--;
                Heapify(arr, left, right);
            }
        }
    }
}
