#region Using directives

using System.Collections.Generic;

#endregion

namespace InsertionSort
{
    public class ImprovedInsertionAlgorith<T> : ISortAlgorith<T>
    {
        private readonly Comparer<T> comparer = Comparer<T>.Default;

        #region ISortAlgorith<T> Members

        public IEnumerable<T> SortAscending(T[] source)
        {
            for (var i = 1; i < source.Length; i++)
            {
                var value = source[i];
                
                for (var j = i - 1; j >= 0 && comparer.Compare(source[j], value) > 0; )
                {
                    source[j + 1] = source[j--];
                    source[j + 1] = value;
                }
            }
            return source;
        }

        public IEnumerable<T> SortDescending(T[] source)
        {
            for (var i = source.Length - 2; i >= 0; i--)
            {
                var value = source[i];
                for (var j = i + 1; j < source.Length && comparer.Compare(source[j], value) > 0; )
                {
                    source[j - 1] = source[j++];
                    source[j - 1] = value;
                }
            }
            return source;
        }

        #endregion
    }
}