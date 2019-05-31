using Project3.Classes.Arrays;
using Project3.Classes.Sorting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingBase[] sortings = { new SelectionSort(), new InsertionSort(), new HeapSort(), new CocktailSort() };
            ArrayBase[] arrays = { new AscendingArray(), new DescendingArray(), new ConstArray(), new RandomArray(), new VShapedArray() };
            int minSize = 50000, maxSize = 200000, step = 10000;

            Engine(arrays, sortings, minSize, maxSize, step);
            Console.ReadKey();
        }

        static void Engine(ArrayBase[] arrays, SortingBase[] sortings, int first, int last, int step)
        {
            Console.WriteLine("array size; array type; sorting method; time [number of ticks]");
            for (int i = first; i <= last; i+= step)
            {
                foreach(var a in arrays)
                {
                    int[] arrayForSort = a.CreateArray(i);
                    foreach(var s in sortings)
                    {
                        int[] tempArray = new int[i];
                        Array.Copy(arrayForSort, tempArray, i);
                        long start = Stopwatch.GetTimestamp();
                        s.Sort(tempArray);
                        long stop = Stopwatch.GetTimestamp();
                        Console.WriteLine("{0};{1};{2};{3}", i, a.Name, s.Name, stop - start);
                    }
                }
            }
        }
    }
}
