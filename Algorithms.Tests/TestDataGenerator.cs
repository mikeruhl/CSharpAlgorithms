using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests
{
    public class TestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]{new[] { 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5 }},
            new object[]{new[] { 1000, 200, 444, 67, 11, 67, 4 }, new[] { 4, 11, 67, 67, 200, 444, 1000 }},
            new object[]{new[] { 1, 3, 5, 7, 9 }, new[] { 1, 3, 5, 7, 9 }},
            new object[]{new[] { 2, 1 }, new[] { 1, 2 }},
            new object[]{new[] { 111, 999, 222, 888, 333, 777, 444 }, new[] { 111, 222, 333, 444, 777, 888, 999 }}
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
