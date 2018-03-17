using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Core
{
    public class QuickSort
    {


        public int[] Sort(int[] input, PivotOption option = PivotOption.Random)
        {
            if (input.Length < 2)
                return input;

            var left = new List<int> ();
            var right = new List<int>();

            var pivot = GetPivot(input, option);

            var pivotValue = input[pivot];

            input = input.Slice(0, pivot).Concat(input.Where((v, i) => i > pivot)).ToArray();

            foreach (var item in input)
            {
                if (item < pivotValue)
                {
                    left.Add(item);
                }
                else
                {
                    right.Add(item);
                }
            }

            return Sort(left.ToArray(), option).Concat(new[] {pivotValue}.Concat(Sort(right.ToArray(), option))).ToArray();

        }

        private int GetPivot(int[] input, PivotOption option)
        {
            switch(option)
            {
                case PivotOption.First:
                    return 0;
                case PivotOption.Last:
                    return input.Length - 1;
                case PivotOption.Random:
                    return new Random().Next(input.Length);
                default:
                    return input.Length / 2;  
            }
        }
        
    }

    public enum PivotOption
    {
        First,
        Last,
        Random,
        Median
    }
}
