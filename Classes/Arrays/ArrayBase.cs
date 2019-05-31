using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Classes.Arrays
{
    abstract public class ArrayBase
    {
        public string Name { get; set; }

        public abstract int[] CreateArray(int size);
    }
}
