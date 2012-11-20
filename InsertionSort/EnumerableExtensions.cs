using System;
using System.Collections.Generic;
using System.Linq;

namespace InsertionSort
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Sort<T>(this IEnumerable<T> source, ISortAlgorith<T> algorith, SortDirection direction = SortDirection.Asc)
        {
            var input = source.ToArray();
            return direction == SortDirection.Asc
                       ? algorith.SortAscending(input)
                       : algorith.SortDescending(input);
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> range)
        {
            var array = range.ToArray();
            var rnd = new Random();
            ShuffleByRandom(array, rnd);
            return array;
        }

        private static void ShuffleByRandom<T>(IList<T> array, Random rnd)
        {
            for (var i = 0; i < array.Count; i++)
            {
                var index = rnd.Next(array.Count);
                var temp = array[index];
                array[index] = array[i];
                array[i] = temp;
            }
        }
    }
}