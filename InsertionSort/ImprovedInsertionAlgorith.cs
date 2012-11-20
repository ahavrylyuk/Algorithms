#region Using directives

using System.Collections.Generic;

#endregion

namespace InsertionSort
{
    internal class ImprovedInsertionAlgorith<T> : ISortAlgorith<T>
    {
        public IEnumerable<T> Sort(T[] source)
        {
            return SortInplace(source);
        }

        public IEnumerable<T> SortInplace(T[] source)
        {
            for (var i = 1; i < source.Length; i++)
            {
                var value = source[i];
                for (var j = i - 1; j >= 0 && Comparer<T>.Default.Compare(source[j], value) > 0; )
                {
                    source[j + 1] = source[j--];
                    source[j + 1] = value;
                }
            }
            return source;
        }
    }
}