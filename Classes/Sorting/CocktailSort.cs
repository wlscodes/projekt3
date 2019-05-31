using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Classes.Sorting
{
    public sealed class CocktailSort : SortingBase
    {
        public CocktailSort()
        {
            Name = "Cocktail Sort";
        }
        public override void Sort(int[] arr)
        {
            int left = 1, right = arr.Length - 1, k = arr.Length - 1;
            do
            {
                for (int j = right; j >= left; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int tmp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = tmp;
                        k = j;
                    }
                }

                left = k + 1;

                for (int j = left; j <= right; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int tmp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = tmp;
                        k = j;
                    }
                }

                right = k - 1;
            } while (left <= right);
        }
    }
}
