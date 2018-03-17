using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core
{
    public class MergedSort
    {
        public int[] Sort(int[] input)
        {
            if (input.Length <= 1)
                return input;

            var middle = input.Length / 2;
            var leftSide = input.Where((i, p) => p >= 0 && p < middle).ToArray();
            var rightSide = input.Where((i, p) => p >= middle).ToArray();
            return Merge(Sort(leftSide), Sort(rightSide));
        }

        private int[] Merge(int[] left, int[] right)
        {
            var result = new List<int>();
            while (left.Length > 0 || right.Length > 0)
            {
                if (left.Length > 0 && right.Length > 0)
                {
                    if (left[0] < right[0])
                    {
                        result.Add(left.Shift(out left));
                    }
                    else
                    {
                        result.Add(right.Shift(out right));
                      
                    }
                }
                else if (left.Length > 0)
                {
                    result.Add(left.Shift(out left));
                }
                else
                {
                    result.Add(right.Shift(out right));
                }
            }

            return result.ToArray();
        }
    }


}
