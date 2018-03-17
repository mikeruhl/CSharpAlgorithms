using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Core;
using Xunit;

namespace Algorithms.Tests
{
    public class QuickSortTests
    {
        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void ShouldSortArraysFirst(int[] input, int[] expected)
        {
            var sorter = new QuickSort();

            var sorterOutput = sorter.Sort(input, PivotOption.First);

            Assert.Equal(expected, sorterOutput);
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void ShouldSortArraysLast(int[] input, int[] expected)
        {
            var sorter = new QuickSort();

            var sorterOutput = sorter.Sort(input, PivotOption.Last);

            Assert.Equal(expected, sorterOutput);
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void ShouldSortArraysRandom(int[] input, int[] expected)
        {
            var sorter = new QuickSort();

            var sorterOutput = sorter.Sort(input, PivotOption.Random);

            Assert.Equal(expected, sorterOutput);
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void ShouldSortArraysMedian(int[] input, int[] expected)
        {
            var sorter = new QuickSort();

            var sorterOutput = sorter.Sort(input, PivotOption.Median);

            Assert.Equal(expected, sorterOutput);
        }
    }
}
