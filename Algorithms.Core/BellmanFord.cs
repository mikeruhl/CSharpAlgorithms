using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Core.Models;

namespace Algorithms.Core
{
    public class BellmanFord
    {
        public Dictionary<string, int> GetLowestCost(IEnumerable<Edge> edges, string startNode)
        {
            var enumerable = edges as Edge[] ?? edges.ToArray();
            var uniqueVertices = enumerable.Select(e => e.From)
                .Concat(enumerable.Select(e => e.To))
                .GroupBy(e => e)
                .Select(g => g.Key)
                .OrderBy(e=>e);

            var memo = uniqueVertices.ToDictionary(edge => edge, edge => edge == startNode ? 0 : int.MaxValue);

            var doItAgain = true;
            while (doItAgain)
            {
                doItAgain = false;
                foreach (var vertex in uniqueVertices)
                {
                    var vertexEdges = enumerable.Where(e => e.From == vertex).ToArray();

                    foreach (var edge in vertexEdges)
                    {
                        var potentialCost = memo[edge.From] == int.MaxValue ? int.MaxValue : memo[edge.From] + edge.Cost;
                        //reset cost as needed
                        if (potentialCost < memo[edge.To])
                        {
                            memo[edge.To] = potentialCost;
                            doItAgain = true;
                        }
                            
                    }
                }
            }

            return memo;
        }


    }
}
