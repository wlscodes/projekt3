using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Classes.Sorting
{
    public sealed class QuickSortIteration : SortingBase
    {
        public QuickSortIteration()
        {
            Name = "Quick Sort - Iteration";
        }

        public override void Sort(int[] arr)
        {
            int i, j, l, p, sp;
            int[] stos_l = new int[arr.Length],
                stos_p = new int[arr.Length];
            sp = 0;
            stos_l[sp] = 0;
            stos_p[sp] = arr.Length - 1;

            do
            {
                l = stos_l[sp];
                p = stos_p[sp];
                sp--;

                do
                {
                    int x;
                    i = l;
                    j = p;
                    x = arr[(l + p) / 2];
                    do
                    {
                        while (arr[i] < x) i++;
                        while (x < arr[j]) j--;
                        if (i <= j)
                        {
                            int buf = arr[i];
                            arr[i] = arr[j];
                            arr[j] = buf;
                            i++;
                            j--;
                        }
                    } while (i <= j);

                    if (i < p)
                    {
                        sp++;
                        stos_l[sp] = i;
                        stos_p[sp] = p;
                    }
                    p = j;
                } while (l < p);
            } while (sp >= 0);
        }
    }
}
