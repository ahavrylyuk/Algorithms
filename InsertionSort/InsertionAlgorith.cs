using System.Collections.Generic;

namespace InsertionSort
{
    internal class InsertionAlgorith : ISortAlgorith<int>
    {
        public IEnumerable<int> Sort(int[] source)
        {
            return SortInplace(source);
        }

        public IEnumerable<int> SortInplace(int[] source)
        {
            for (var i = 1; i < source.Length; i++)
            {
                var value = source[i];
                for (var j = i - 1; j >= 0; j--)
                {
                    var previous = source[j];
                    if (value < previous)
                    {
                        var temp = source[j];
                        source[j] = source[j + 1];
                        source[j + 1] = temp;
                    }
                }
            }
            return source;
        }
    }
}