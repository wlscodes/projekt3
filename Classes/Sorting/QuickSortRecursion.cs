using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Classes.Sorting
{
    public sealed class QuickSortRecursion : SortingBase
    {
        public QuickSortRecursion()
        {
            Name = "Quick Sort - Recursion";
        }
        private void Sort(int[] tab, int left, int right)
        {
            int i, j, x;
            i = left;
            j = right;
            x = tab[(left + right) / 2];

            do
            {
                while (tab[i] < x) i++;
                while (x < tab[j]) j--;
                if (i <= j)
                {
                    int buf = tab[i];
                    tab[i] = tab[j];
                    tab[j] = buf;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (left < j) Sort(tab, left, j);
            if (i < right) Sort(tab, i, right);
        }

        public override void Sort(int[] tab)
        {
            Sort(tab, 0, tab.Length - 1);
        }
    }
}
