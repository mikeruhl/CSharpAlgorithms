using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Core;
using Xunit;

namespace Algorithms.Tests
{
    public class SelectionSortTests
    {
        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void ShouldSortArrays(int[] input, int[] expected)
        {
            var sorter = new SelectionSort();

            var sorterOutput = sorter.Sort(input);

            Assert.Equal(expected, sorterOutput);
        }
    }
}
