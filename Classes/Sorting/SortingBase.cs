using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Classes.Sorting
{
    public abstract class SortingBase
    {
        public string Name { get; set; }

        public abstract void Sort(int[] arr);
    }
}
