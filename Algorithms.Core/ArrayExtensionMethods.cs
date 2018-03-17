using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core
{
    public static class ArrayExtensionMethods
    {
        public static T Shift<T>(this T[] array, out T[] outArray)
        {
            if(array.Length == 0)
                throw new ArgumentException("Array length must be greater than zero", nameof(array));
            var ret = array[0];
            outArray = array.Where((v, i) => i > 0).ToArray();
            return ret;
        }

        public static T[] Slice<T>(this T[] source, int start, int end)
        {
            // Handles negative ends.
            if (end < 0)
            {
                end = source.Length + end;
            }
            var len = end - start;

            // Return new array.
            var res = new T[len];
            for (var i = 0; i < len; i++)
            {
                res[i] = source[i + start];
            }
            return res;
        }
    }
}
