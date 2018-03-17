using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Core;
using Algorithms.Core.Models;
using Xunit;

namespace Algorithms.Tests
{
    public class BellmanFordTests
    {

        private Edge[] GetGraph()
        {
            return new[]
            {
                new Edge
                {
                    From = "S",
                    To = "A",
                    Cost = 4
                },
                new Edge
                {
                    From = "S",
                    To = "E",
                    Cost = -5
                },
                new Edge
                {
                    From = "A",
                    To = "C",
                    Cost = 6
                },
                new Edge
                {
                    From = "B",
                    To = "A",
                    Cost = 3
                },
                new Edge
                {
                    From = "C",
                    To = "B",
                    Cost = -2
                },
                new Edge
                {
                    From = "D",
                    To = "C",
                    Cost = 3
                },
                new Edge
                {
                    From = "D",
                    To = "A",
                    Cost = 10
                },
                new Edge
                {
                    From = "E",
                    To = "D",
                    Cost = 8
                }
            };
        }

        [Fact]
        public void ShouldReturnCostsFromS()
        {
            var graph = GetGraph();


            var memo = new BellmanFord().GetLowestCost(graph, "S");

            AssertValues(memo, 0, 4, 4, 6, 3, -5);

        }

        [Fact]
        public void ShouldReturnCostsFromA()
        {
            var graph = GetGraph();
            var memo = new BellmanFord().GetLowestCost(graph, "A");

            AssertValues(memo, int.MaxValue, 0, 4, 6, int.MaxValue, int.MaxValue);

        }

        [Fact]
        public void ShouldReturnCostsFromB()
        {
            var graph = GetGraph();
            var memo = new BellmanFord().GetLowestCost(graph, "B");

            AssertValues(memo, int.MaxValue, 3, 0, 9, int.MaxValue, int.MaxValue);

        }

        [Fact]
        public void ShouldReturnCostsFromC()
        {
            var graph = GetGraph();
            var memo = new BellmanFord().GetLowestCost(graph, "C");

            AssertValues(memo, int.MaxValue, 1, -2, 0, int.MaxValue, int.MaxValue);

        }

        [Fact]
        public void ShouldReturnCostsFromD()
        {
            var graph = GetGraph();
            var memo = new BellmanFord().GetLowestCost(graph, "D");

            AssertValues(memo, int.MaxValue, 4, 1, 3, 0, int.MaxValue);

        }

        [Fact]
        public void ShouldReturnCostsFromE()
        {
            var graph = GetGraph();
            var memo = new BellmanFord().GetLowestCost(graph, "E");

            AssertValues(memo, int.MaxValue, 12, 9, 11, 8, 0);

        }

        private void AssertValues(Dictionary<string, int> memo, int s, int a, int b, int c, int d, int e)
        {
            Assert.Equal(s, memo["S"]);
            Assert.Equal(a, memo["A"]);
            Assert.Equal(b, memo["B"]);
            Assert.Equal(c, memo["C"]);
            Assert.Equal(d, memo["D"]);
            Assert.Equal(e, memo["E"]);
        }
    }
}
