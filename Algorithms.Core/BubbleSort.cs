using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core
{
    public class BubbleSort
    {
        public int[] Sort(int[] array)
        {
            var doItAgain = false;
            var uL = array.Length;
            const int defaultNextVal = int.MaxValue;

            for (var i = 0; i < uL; i++)
            {
                var value1 = array[i];
                var value2 = i + 1 < uL ? array[i + 1] : defaultNextVal;
                if (value2 < value1)
                {
                    array[i] = value2;
                    array[i + 1] = value1;
                    doItAgain = true;
                }
            }

            if (doItAgain)
                Sort(array);

            return array;
        }

    }
}
