using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core
{
    public class Fibonacci
    {
        public IEnumerable<int> CalculateSequence(int numbers)
        {
            for (var i = 0; i < numbers; i++)
            {
               yield return CalculateFibAt(i);
            }
        }

        public IEnumerable<int> CalculateSequenceFast(int numbers)
        {
            var sequence = new List<int> {0, 1};

            for (var i = 2; i < numbers; i++)
            {
                sequence.Add(sequence[i-2] + sequence[i-1]);
            }

            return sequence.GetRange(0, numbers);
        }

        public int CalculateDigitGreedy(int digit)
        {
            if(digit <= 0)
                throw new IndexOutOfRangeException("Digit must be greater than 0");
            var twoFibsAgo = 0;
            var oneFibAgo = 1;
            var currentFib = 0;

            for (var i = 2; i < digit; i++)
            {
                currentFib = twoFibsAgo + oneFibAgo;
                twoFibsAgo = oneFibAgo;
                oneFibAgo = currentFib;
            }

            return currentFib;
        }

        private int CalculateFibAt(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return CalculateFibAt(n - 2) + CalculateFibAt(n - 1);
            }
        }
    }
}
