using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core
{
    public class SelectionSort
    {
        public int[] Sort(int[] input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                var currentMin = i;
                for (var k = currentMin + 1; k < input.Length; k++)
                {
                    if (input[k] < input[currentMin])
                    {
                        currentMin = k;
                    }
                }

                if (currentMin != i)
                {
                    var oldMin = input[i];
                    input[i] = input[currentMin];
                    input[currentMin] = oldMin;
                }
            }

            return input;
        }
    }
}
