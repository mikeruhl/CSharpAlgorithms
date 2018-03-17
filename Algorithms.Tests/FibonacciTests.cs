using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Algorithms.Core;
using Xunit;

namespace Algorithms.Tests
{
    public class FibonacciTests
    {
        [Theory]
        [ClassData(typeof(FibonacciTestData))]
        public void ShouldReturnCorrectSequenceSlow(int input, int[] expected)
        {
            Assert.Equal(expected,new Fibonacci().CalculateSequence(input).ToArray());           
        }


        [Theory]
        [ClassData(typeof(FibonacciTestData))]
        public void ShouldReturnCorrectSequenceFast(int input, int[] expected)
        {
            Assert.Equal(expected, new Fibonacci().CalculateSequenceFast(input).ToArray());
        }

        [Theory]
        [ClassData(typeof(FibonacciTestData))]
        public void ShouldReturnCorrectDigit(int input, int[] expected)
        {
            if (expected.Length == 0)
            {
               var ex = Assert.Throws<IndexOutOfRangeException>(() => new Fibonacci().CalculateDigitGreedy(input));
                Assert.Equal("Digit must be greater than 0", ex.Message);
            }
            else
            {
                Assert.Equal(expected[input - 1], new Fibonacci().CalculateDigitGreedy(input));
            }
           
        }

    }

    public class FibonacciTestData : IEnumerable<object[]>
    {
        private readonly List<Object[]> _data = new List<object[]>
        {
            new object[] {3, new[] {0, 1, 1}},
            new object[] {10, new[] {0, 1, 1, 2, 3, 5, 8, 13, 21, 34}},
            new object[] {0, new int[0]}
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
